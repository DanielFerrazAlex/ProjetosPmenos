using AutoMapper;
using DB_Validate.Data.Dtos;
using DB_Validate.Models;

namespace DB_Validate.Profiles;

public class DbvalidateProfile : Profile
{
	public DbvalidateProfile()
	{
		CreateMap<CreateUserDto, dbvalidate>();
	}
}
