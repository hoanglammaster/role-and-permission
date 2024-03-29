﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System_Management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SystemManagementEntities : DbContext
    {
        public SystemManagementEntities()
            : base("name=SystemManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<ApplicationDetail> ApplicationDetails { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassOfStudent> ClassOfStudents { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Curiculum> Curiculums { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<GradeHasCategory> GradeHasCategorys { get; set; }
        public virtual DbSet<GradeHasItem> GradeHasItems { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleToPermission> RoleToPermissions { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<SemesterOfStudent> SemesterOfStudents { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserToRole> UserToRoles { get; set; }
        public virtual DbSet<SchoolHasUser> SchoolHasUsers { get; set; }
        public virtual DbSet<ApplicationType> ApplicationTypes { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<string> sp_UserLogin(string userName, Nullable<int> school)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var schoolParameter = school.HasValue ?
                new ObjectParameter("School", school) :
                new ObjectParameter("School", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_UserLogin", userNameParameter, schoolParameter);
        }
    
        public virtual ObjectResult<string> LoginUser(string userName, Nullable<int> school)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var schoolParameter = school.HasValue ?
                new ObjectParameter("School", school) :
                new ObjectParameter("School", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginUser", userNameParameter, schoolParameter);
        }
    
        public virtual ObjectResult<sp_SearchNews_Result> sp_SearchNews(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SearchNews_Result>("sp_SearchNews", titleParameter);
        }
    
        public virtual ObjectResult<News> SearchNewsByTitle(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<News>("SearchNewsByTitle", titleParameter);
        }
    
        public virtual ObjectResult<News> SearchNewsByTitle(string title, MergeOption mergeOption)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<News>("SearchNewsByTitle", mergeOption, titleParameter);
        }
    
        public virtual int stp_InsertApplication(Nullable<int> title, Nullable<int> userId, string content, string fileName, byte[] fileBytes)
        {
            var titleParameter = title.HasValue ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            var fileNameParameter = fileName != null ?
                new ObjectParameter("FileName", fileName) :
                new ObjectParameter("FileName", typeof(string));
    
            var fileBytesParameter = fileBytes != null ?
                new ObjectParameter("FileBytes", fileBytes) :
                new ObjectParameter("FileBytes", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_InsertApplication", titleParameter, userIdParameter, contentParameter, fileNameParameter, fileBytesParameter);
        }
    
        public virtual int SendApp(Nullable<int> title, Nullable<int> userId, string content, string fileName, byte[] fileBytes)
        {
            var titleParameter = title.HasValue ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var contentParameter = content != null ?
                new ObjectParameter("Content", content) :
                new ObjectParameter("Content", typeof(string));
    
            var fileNameParameter = fileName != null ?
                new ObjectParameter("FileName", fileName) :
                new ObjectParameter("FileName", typeof(string));
    
            var fileBytesParameter = fileBytes != null ?
                new ObjectParameter("FileBytes", fileBytes) :
                new ObjectParameter("FileBytes", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SendApp", titleParameter, userIdParameter, contentParameter, fileNameParameter, fileBytesParameter);
        }
    }
}
