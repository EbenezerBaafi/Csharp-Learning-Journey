using ObjectOrientedProgramming;


Console.WriteLine("---------------------------------------");
Console.WriteLine("----Object Oriented Programming--------");

Student student1 = new Student("John", 21, "Computer Science", 300, "Human Computer Interaction ");
var student1Info = student1.showInfo();
Console.WriteLine(student1Info);

Student student2 = new Student("Eben", 22, "Computer Science", 300, "DCIT 308");
var student2Info = student2.showInfo();
Console.WriteLine(student2.showInfo());

student2.Name = "";  // Uses the property method and after that you call it
student2Info = student2.showInfo(); 
student2.School = "University of Ghana";
student2.isGraduated = true;
Console.WriteLine(student2Info);
Console.WriteLine(student2.showInfo()); 