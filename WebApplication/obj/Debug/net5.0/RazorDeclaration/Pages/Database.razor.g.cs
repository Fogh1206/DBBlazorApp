// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\Pages\Database.razor"
using WebApplication.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\Pages\Database.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/database")]
    public partial class Database<TValue> : InputBase<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\esben\RiderProjects\WebApplication\WebApplication\Pages\Database.razor"
 
    
    protected override bool TryParseValueFromString(string value, 
        out TValue result, out string errorMessage)
    {
        var success = BindConverter.TryConvertTo<TValue>(
            value, CultureInfo.CurrentCulture, out var parsedValue);
        if (success)
        {
            result = parsedValue;
            errorMessage = null;

            return true;
        }
        else
        {
            result = default;
            errorMessage = $"{FieldIdentifier.FieldName} field isn't valid.";

            return false;
        }
    }
    
    [Parameter]
    public bool SelectedValue { get; set; }

    private void OnChange(ChangeEventArgs args)
    {
        CurrentValueAsString = args.Value.ToString();
    }
    public ComponentActive CurrentComponentActive { get; set; }
    
    private int courseId { get; set; }
    private string courseName { get; set; }
    private int courseSemester { get; set; }
    private bool courseIsElective { get; set; }
    

    public void SetAddActive(MouseEventArgs e)
    {
        CurrentComponentActive = ComponentActive.Add;
    }
    
    public void SetEditActive(MouseEventArgs e)
    {
        CurrentComponentActive = ComponentActive.Edit;
    }
    
    public void SetRemoveActive(MouseEventArgs e)
    {
        CurrentComponentActive = ComponentActive.Remove;
    }
    
    

    protected override async Task OnInitializedAsync()
    {
        SelectedValue = false;
        InsertCourse();
        InsertProgramme();
    }

    private async Task InsertCourse()
    {
        Course dnp1 = new Course
        {
            Id = "DNP1",
            Name = "Internet Technologies, C# and .NET",
            Semester = 3,
            IsElective = false,
        };

        using ViaDBContext dbContext = new ViaDBContext();

        await dbContext.Courses.AddAsync(dnp1);
        await dbContext.SaveChangesAsync();

    }

    private async Task InsertProgramme()
    {
        Course SDJ2 = new Course
        {
            Id = "SDJ2",
            Name = "Software Development with Java and UML 2",
            Semester = 2,
            IsElective = false
        };
        Course GMD = new Course
        {
            Id = "GMD1",
            Name = "Game Development",
            Semester = 6,
            IsElective = true
        };

        List<Course> courses = new List<Course> {GMD, SDJ2};
        Programme software = new Programme
        {
            Location = "Horsens",
            Name = "Software Technology Engineering",
            ShortName = "Software",
            HeadOfDepartment = "AHM",
            Courses = courses
        };

        using (ViaDBContext dbContext = new ViaDBContext())
        {
            await dbContext.Programmes.AddAsync(software);
            await dbContext.SaveChangesAsync();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591