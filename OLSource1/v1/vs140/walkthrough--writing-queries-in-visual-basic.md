---
title: "Walkthrough: Writing Queries in Visual Basic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: get-started-article
dev_langs: 
  - VB
helpviewer_keywords: 
  - queries [LINQ in Visual Basic], writing
  - LINQ [Visual Basic], walkthroughs
  - LINQ [Visual Basic], writing queries
  - writing LINQ queries [Visual Basic]
ms.assetid: f0045808-b9fe-4d31-88d1-473d9957211e
caps.latest.revision: 74
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Writing Queries in Visual Basic
This walkthrough demonstrates how you can use Visual Basic language features to write [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] query expressions. The walkthrough demonstrates how to create queries on a list of Student objects, how to run the queries, and how to modify them. The queries incorporate several features including object initializers, local type inference, and anonymous types.  
  
 After completing this walkthrough, you will be ready to move on to the samples and documentation for the specific [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider you are interested in. [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] providers include [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], [!INCLUDE[linq_dataset](../vs140/includes/linq_dataset_md.md)], and [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)].  
  
## Create a Project  
  
#### To create a console application project  
  
1.  Start Visual Studio.  
  
2.  On the **File** menu, point to **New**, and then click **Project**.  
  
3.  In the **Installed Templates** list, click **Visual Basic**.  
  
4.  In the list of project types, click **Console Application**. In the **Name** box, type a name for the project, and then click **OK**.  
  
     A project is created. By default, it contains a reference to System.Core.dll. Also, the **Imported namespaces** list on the [References Page, Project Designer (Visual Basic)](../vs140/references-page--project-designer--visual-basic-.md) includes the <xref:System.Linq?qualifyHint=True> namespace.  
  
5.  On the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md), ensure that **Option infer** is set to **On**.  
  
## Add an In-Memory Data Source  
 The data source for the queries in this walkthrough is a list of `Student` objects. Each `Student` object contains a first name, a last name, a class year, and an academic rank in the student body.  
  
#### To add the data source  
  
-   Define a `Student` class, and create a list of instances of the class.  
  
    > [!IMPORTANT]
    >  The code needed to define the `Student` class and create the list used in the walkthrough examples is provided in [How to: Create a List of Students for the Visual Basic Walkthrough](../vs140/how-to--create-a-list-of-items.md). You can copy it from there and paste it into your project. The new code replaces the code that appeared when you created the project.  
  
#### To add a new student to the students list  
  
-   Follow the pattern in the `getStudents` method to add another instance of the `Student` class to the list. Adding the student will introduce you to object initializers. For more information, see [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md).  
  
## Create a Query  
 When executed, the query added in this section produces a list of the students whose academic rank puts them in the top ten. Because the query selects the complete `Student` object each time, the type of the query result is `IEnumerable(Of Student)`. However, the type of the query typically is not specified in query definitions. Instead, the compiler uses local type inference to determine the type. For more information, see [Local Type Inference](../vs140/local-type-inference--visual-basic-.md). The query's range variable, `currentStudent`, serves as a reference to each `Student` instance in the source, `students`, providing access to the properties of each object in `students`.  
  
#### To create a simple query  
  
1.  Find the place in the `Main` method of the project that is marked as follows:  
  
     [!code[VbLINQWalkthrough#1](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_1.vb)]
  
  
     Copy the following code and paste it in.  
  
     [!code[VbLINQWalkthrough#2](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_2.vb)]
  
  
2.  Rest the mouse pointer over `studentQuery` in your code to verify that the compiler-assigned type is `IEnumerable(Of Student)`.  
  
## Run the Query  
 The variable `studentQuery` contains the definition of the query, not the results of running the query. A typical mechanism for running a query is a `For Each` loop. Each element in the returned sequence is accessed through the loop iteration variable. For more information about query execution, see [Three Parts of a LINQ Query](../vs140/writing-your-first-linq-query--visual-basic-.md).  
  
#### To run the query  
  
1.  Add the following `For Each` loop below the query in your project.  
  
     [!code[VbLINQWalkthrough#3](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_3.vb)]
  
  
2.  Rest the mouse pointer over the loop control variable `studentRecord` to see its data type. The type of `studentRecord` is inferred to be `Student`, because `studentQuery` returns a collection of `Student` instances.  
  
3.  Build and run the application by pressing CTRL+F5. Note the results in the console window.  
  
## Modify the Query  
 It is easier to scan query results if they are in a specified order. You can sort the returned sequence based on any available field.  
  
#### To order the results  
  
1.  Add the following `Order By` clause between the `Where` statement and the `Select` statement of the query. The `Order By` clause will order the results alphabetically from A to Z, according to the last name of each student.  
  
    ```  
    Order By currentStudent.Last Ascending   
    ```  
  
2.  To order by last name and then first name, add both fields to the query:  
  
    ```  
    Order By currentStudent.Last Ascending, currentStudent.First Ascending   
    ```  
  
     You can also specify `Descending` to order from Z to A.  
  
3.  Build and run the application by pressing CTRL+F5. Note the results in the console window.  
  
#### To introduce a local identifier  
  
1.  Add the code in this section to introduce a local identifier in the query expression. The local identifier will hold an intermediate result. In the following example, `name` is an identifier that holds a concatenation of the student's first and last names. A local identifier can be used for convenience, or it can enhance performance by storing the results of an expression that would otherwise be calculated multiple times.  
  
     [!code[VbLINQWalkthrough#4](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_4.vb)]
  
  
2.  Build and run the application by pressing CTRL+F5. Note the results in the console window.  
  
#### To project one field in the Select clause  
  
1.  Add the query and `For Each` loop from this section to create a query that produces a sequence whose elements differ from the elements in the source. In the following example, the source is a collection of `Student` objects, but only one member of each object is returned: the first name of students whose last name is Garcia. Because `currentStudent.First` is a string, the data type of the sequence returned by `studentQuery3` is `IEnumerable(Of String)`, a sequence of strings. As in earlier examples, the assignment of a data type for `studentQuery3` is left for the compiler to determine by using local type inference.  
  
     [!code[VbLINQWalkthrough#5](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_5.vb)]
  
  
2.  Rest the mouse pointer over `studentQuery3` in your code to verify that the assigned type is `IEnumerable(Of String)`.  
  
3.  Build and run the application by pressing CTRL+F5. Note the results in the console window.  
  
#### To create an anonymous type in the Select clause  
  
1.  Add the code from this section to see how anonymous types are used in queries. You use them in queries when you want to return several fields from the data source rather than complete records (`currentStudent` records in previous examples) or single fields (`First` in the preceding section). Instead of defining a new named type that contains the fields you want to include in the result, you specify the fields in the `Select` clause and the compiler creates an anonymous type with those fields as its properties. For more information, see [Anonymous Types](../vs140/anonymous-types--visual-basic-.md).  
  
     The following example creates a query that returns the name and rank of seniors whose academic rank is between 1 and 10, in order of academic rank. In this example, the type of `studentQuery4` must be inferred because the `Select` clause returns an instance of an anonymous type, and an anonymous type has no usable name.  
  
     [!code[VbLINQWalkthrough#6](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_6.vb)]
  
  
2.  Build and run the application by pressing CTRL+F5. Note the results in the console window.  
  
## Additional Examples  
 Now that you understand the basics, the following is a list of additional examples to illustrate the flexibility and power of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries. Each example is preceded by a brief description of what it does. Rest the mouse pointer over the query result variable for each query to see the inferred type. Use a `For Each` loop to produce the results.  
  
 [!code[VbLINQWalkthrough#7](../vs140/codesnippet/VisualBasic/walkthrough--writing-queries-in-visual-basic_7.vb)]
  
  
## Additional Information  
 After you are familiar with the basic concepts of working with queries, you are ready to read the documentation and samples for the specific type of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider that you are interested in:  
  
 [LINQ to Objects](../vs140/linq-to-objects.md)  
  
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)  
  
 [LINQ to XML](../vs140/linq-to-xml.md)  
  
 [LINQ to DataSet](assetId:///743e3755-3ecb-45a2-8d9b-9ed41f0dcf17)  
  
## See Also  
 [Language-Integrated Query (LINQ) (Visual Basic)](../vs140/language-integrated-query--linq---visual-basic-.md)   
 [Getting Started with LINQ in Visual Basic](../vs140/getting-started-with-linq-in-visual-basic.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Queries](../vs140/queries--visual-basic-.md)