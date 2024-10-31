package en.via.sep3_t3.dto;

public class HouseOwnerDTO
{
  // attributes from User
  private int userId;
  private String email;
  private String password;
  private String profilePicture;
  private String CPR;
  private String phone;
  private boolean isVerified;
  private int adminId;

  // attributes from HouseOwner
  private String address;
  private String biography;

  public int getUserId()
  {
    return userId;
  }

  public void setUserId(int userId)
  {
    this.userId = userId;
  }

  public String getEmail()
  {
    return email;
  }

  public void setEmail(String email)
  {
    this.email = email;
  }

  public String getPassword()
  {
    return password;
  }

  public void setPassword(String password)
  {
    this.password = password;
  }

  public String getProfilePicture()
  {
    return profilePicture;
  }

  public void setProfilePicture(String profilePicture)
  {
    this.profilePicture = profilePicture;
  }

  public String getCPR()
  {
    return CPR;
  }

  public void setCPR(String CPR)
  {
    this.CPR = CPR;
  }

  public String getPhone()
  {
    return phone;
  }

  public void setPhone(String phone)
  {
    this.phone = phone;
  }

  public boolean isVerified()
  {
    return isVerified;
  }

  public void setVerified(boolean verified)
  {
    isVerified = verified;
  }

  public int getAdminId()
  {
    return adminId;
  }

  public void setAdminId(int adminId)
  {
    this.adminId = adminId;
  }

  public String getAddress()
  {
    return address;
  }

  public void setAddress(String address)
  {
    this.address = address;
  }

  public String getBiography()
  {
    return biography;
  }

  public void setBiography(String biography)
  {
    this.biography = biography;
  }
}
