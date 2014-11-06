<Query Kind="Expression">
  <Connection>
    <ID>f109ae73-4f40-495b-8e84-41279bc35189</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>


 from cat in EmployeeSkills
                              orderby cat.Skill.Description
                              select new 
                                  {
                                      SkillDescription = cat.Skill.Description,
                                      Name = cat.Employee.FirstName + " " + cat.Employee.LastName,
                                      Phone = cat.Employee.HomePhone,
                                      Level = cat.Level,
                                      YOE = cat.YearsOfExperience
                                  }
               