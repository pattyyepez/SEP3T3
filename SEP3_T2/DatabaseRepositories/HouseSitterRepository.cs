﻿using DTOs.HouseSitter;
using Grpc.Core;
using Grpc.Net.Client;
using RepositoryContracts;

namespace DatabaseRepositories;

public class HouseSitterRepository : IHouseSitterRepository
{

    private readonly HouseSitterService.HouseSitterServiceClient _client;

    public HouseSitterRepository()
    {
            GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:9090", new GrpcChannelOptions
            {  
                Credentials = ChannelCredentials.Insecure,
            });
            _client = new HouseSitterService.HouseSitterServiceClient(channel);
    }

    public Task<HouseSitterDTO> AddAsync(CreateHouseSitterDTO houseSitter)
    {
        HouseSitterResponse reply = _client.CreateHouseSitter(new CreateHouseSitterRequest
        {
            Email = houseSitter.Email,
            Password = houseSitter.Password,
            ProfilePicture = houseSitter.ProfilePicture,
            CPR = houseSitter.CPR,
            Phone = houseSitter.Phone,
            Pictures = { houseSitter.Pictures },
            Skills = { houseSitter.Skills },
            
            Biography = houseSitter.Biography,
            Experience = houseSitter.Experience
        });
        
        return Task.FromResult(new HouseSitterDTO
        {
            UserId = reply.Id,
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Biography = reply.Biography,
            Experience = reply.Experience, 
            Pictures = reply.Pictures.ToList(),
            Skills = reply.Skills.ToList()
        });
    }

    public Task<HouseSitterDTO> UpdateAsync(int id, UpdateHouseSitterDTO houseSitter)
    {
        HouseSitterResponse reply = _client.UpdateHouseSitter(new UpdateHouseSitterRequest()
        {
            Id = id,
            Email = houseSitter.Email,
            Password = houseSitter.Password,
            ProfilePicture = houseSitter.ProfilePicture,
            CPR = houseSitter.CPR,
            Phone = houseSitter.Phone,
            IsVerified = houseSitter.IsVerified,
            AdminId = houseSitter.AdminId,
            
            Biography = houseSitter.Biography,
            Experience = houseSitter.Experience, 
            Pictures = { houseSitter.Pictures },
            Skills = { houseSitter.Skills }
        });
        
        return Task.FromResult(new HouseSitterDTO
        {
            UserId = reply.Id,
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Biography = reply.Biography,
            Experience = reply.Experience, 
            Pictures = reply.Pictures.ToList(),
            Skills = reply.Skills.ToList()
        });
    }

    public Task DeleteAsync(int id)
    {
        _client.DeleteHouseSitter(new HouseSitterRequest()
        {
            Id = id
        });
        
        return Task.CompletedTask;
    }

    // comment
    public Task<HouseSitterDTO> GetSingleAsync(int id)
    {
        HouseSitterResponse reply = _client.GetHouseSitter(new HouseSitterRequest
        {
            Id = id
        });
        return Task.FromResult(new HouseSitterDTO
        {
            UserId = reply.Id,
            
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Biography = reply.Biography,
            Experience = reply.Experience, 
            Pictures = reply.Pictures.ToList(),
            Skills = reply.Skills.ToList()
        });
    }

    public IQueryable<HouseSitterDTO> GetAll()
    {
        AllHouseSittersResponse reply = _client.GetAllHouseSitters(new AllHouseSittersRequest());
        var houseSitterResponses = reply.HouseSitters.ToList();
        var houseSitters = new List<HouseSitterDTO>();

        foreach (var houseSitter in houseSitterResponses)
        {
            houseSitters.Add(new HouseSitterDTO
            {
                UserId = houseSitter.Id,
            
                Email = houseSitter.Email,
                Password = houseSitter.Password,
                ProfilePicture = houseSitter.ProfilePicture,
                CPR = houseSitter.CPR,
                Phone = houseSitter.Phone,
                IsVerified = houseSitter.IsVerified,
                AdminId = houseSitter.AdminId,
            
                Biography = houseSitter.Biography,
                Experience = houseSitter.Experience, 
                Pictures = houseSitter.Pictures.ToList(),
                Skills = houseSitter.Skills.ToList()
            });
        }

        return houseSitters.AsQueryable();
    }
}