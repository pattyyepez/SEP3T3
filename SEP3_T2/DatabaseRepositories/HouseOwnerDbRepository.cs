﻿using DTOs;
using DTOs.HouseOwner;
using Grpc.Core;
using Grpc.Net.Client;
using RepositoryContracts;

namespace DatabaseRepositories;

public class HouseOwnerDbRepository : IHouseOwnerRepository
{

    private readonly HouseOwnerService.HouseOwnerServiceClient client;

    public HouseOwnerDbRepository()
    {
            GrpcChannel channel = GrpcChannel.ForAddress("http://localhost:9090", new GrpcChannelOptions
            {  
                Credentials = ChannelCredentials.Insecure,
            });
            client = new HouseOwnerService.HouseOwnerServiceClient(channel);
    }

    public Task<HouseOwnerDTO> AddAsync(CreateHouseOwnerDTO houseOwner)
    {
        HouseOwnerResponse reply = client.CreateHouseOwner(new CreateHouseOwnerRequest
        {
            Email = houseOwner.Email,
            Password = houseOwner.Password,
            ProfilePicture = houseOwner.ProfilePicture,
            CPR = houseOwner.CPR,
            Phone = houseOwner.Phone,
            
            Address = houseOwner.Address,
            Biography = houseOwner.Biography
        });
        
        return Task.FromResult(new HouseOwnerDTO
        {
            UserId = reply.Id,
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Address = reply.Address,
            Biography = reply.Biography
        });
    }

    public Task<HouseOwnerDTO> UpdateAsync(int id, UpdateHouseOwnerDTO houseOwner)
    {
        HouseOwnerResponse reply = client.UpdateHouseOwner(new UpdateHouseOwnerRequest()
        {
            Id = id,
            Email = houseOwner.Email,
            Password = houseOwner.Password,
            ProfilePicture = houseOwner.ProfilePicture,
            CPR = houseOwner.CPR,
            Phone = houseOwner.Phone,
            IsVerified = houseOwner.IsVerified,
            AdminId = houseOwner.AdminId,
            
            Address = houseOwner.Address,
            Biography = houseOwner.Biography
        });
        
        return Task.FromResult(new HouseOwnerDTO
        {
            UserId = reply.Id,
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Address = reply.Address,
            Biography = reply.Biography
        });
    }

    public Task DeleteAsync(int id)
    {
        client.DeleteHouseOwner(new HouseOwnerRequest()
        {
            Id = id
        });
        
        return Task.CompletedTask;
    }

    // comment
    public Task<HouseOwnerDTO> GetSingleAsync(int id)
    {
        HouseOwnerResponse reply = client.GetHouseOwner(new HouseOwnerRequest
        {
            Id = id
        });
        
        return Task.FromResult(new HouseOwnerDTO
        {
            UserId = reply.Id,
            Email = reply.Email,
            Password = reply.Password,
            ProfilePicture = reply.ProfilePicture,
            CPR = reply.CPR,
            Phone = reply.Phone,
            IsVerified = reply.IsVerified,
            AdminId = reply.AdminId,
            
            Address = reply.Address,
            Biography = reply.Biography
        });
    }

    public IQueryable<HouseOwnerDTO> GetAll()
    {
        throw new NotImplementedException();
    }
}