using AutoMapper;
using SchoolApi.Dtos.ClassRoomDtos;
using SchoolApi.Dtos.DepartmentDtos;
using SchoolApi.Dtos.EnrollmentDto;
using SchoolApi.Dtos.StudentDtos;
using SchoolApi.Dtos.SubjectDtos;
using SchoolApi.Dtos.TeacherDtos;
using SchoolApi.Models;

namespace SchoolApi.MappingProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<CreateStudentDto, Student>();
            CreateMap<UpdateStudentDto, Student>();

            CreateMap<Teacher, TeacherDto>();
            CreateMap<CreateTeacherDto, Teacher>();
            CreateMap<UpdateTeacherDto, Teacher>();

            CreateMap<Subject, SubjectDto>();
            CreateMap<CreateSubjectDto, Subject>();
            CreateMap<UpdateSubjectDto, Subject>();

            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto , Department>();

            CreateMap<ClassRoom, ClassRoomDto>();
            CreateMap<CreateClassRoomDto, ClassRoom>();
            CreateMap<UpdateClassRoomDto, ClassRoom>();

            CreateMap<Enrollment, EnrollmentDto>();
            CreateMap<CreateEnrollmentDto, Enrollment>();
            CreateMap<UpdateEnrollmentDto, Enrollment>();   



        }
    }
}
