---
title: "Walkthrough: Writing Queries in C# (LINQ)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "LINQ [C#], walkthroughs"
  - "LINQ [C#], writing queries"
  - "queries [LINQ in C#], writing"
  - "writing LINQ queries"
ms.assetid: 2962a610-419a-4276-9ec8-4b7f2af0c081
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Writing Queries in C# (LINQ)
This walkthrough demonstrates the C# language features that are used to write LINQ query expressions.  
  
## Create a C# Project  
  
> [!NOTE]
>  The following instructions are for Visual Studio. If you are using a different development environment, create a console project with a reference to System.Core.dll and a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive for the \<xref:System.Linq*?displayProperty=fullName> namespace.  
  
#### To create a project in Visual Studio  
  
1.  Start Visual Studio.  
  
2.  On the menu bar, choose **File**, **New**, **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Expand **Installed**, expand **Templates**, expand **Visual C#**, and then choose **Console Application**.  
  
4.  In the **Name** text box, enter a different name or accept the default name, and then choose the **OK** button.  
  
     The new project appears in **Solution Explorer**.  
  
5.  Notice that your project has a reference to System.Core.dll and a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive for the \<xref:System.Linq*?displayProperty=fullName> namespace.  
  
## Create an in-Memory Data Source  
 The data source for the queries is a simple list of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects. Each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> record has a first name, last name, and an array of integers that represents their test scores in the class. Copy this code into your project. Note the following characteristics:  
  
-   The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class consists of auto-implemented properties.  
  
-   Each student in the list is initialized with an object initializer.  
  
-   The list itself is initialized with a collection initializer.  
  
 This whole data structure will be initialized and instantiated without explicit calls to any constructor or explicit member access. For more information about these new features, see [Auto-Implemented Properties (C# Programming Guide)](../vs140/auto-implemented-properties--csharp-programming-guide-.md) and [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md).  
  
#### To add the data source  
  
-   Add the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class and the initialized list of students to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class in your project.  
  
     [!code[CsLinqGettingStarted#11](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_1.cs)]  
  
#### To add a new Student to the Students list  
  
1.  Add a new <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> list and use a name and test scores of your choice. Try typing all the new student information in order to better learn the syntax for the object initializer.  
  
## Create the Query  
  
#### To create a simple query  
  
-   In the application's <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method, create a simple query that, when it is executed, will produce a list of all students whose score on the first test was greater than 90. Note that because the whole <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is selected, the type of the query is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Although the code could also use implicit typing by using the [var](../vs140/var--csharp-reference-.md) keyword, explicit typing is used to clearly illustrate results. (For more information about <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, see [Implicitly Typed Local Variables and Arrays (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md).)  
  
     Note also that the query's range variable, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, serves as a reference to each <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in the source, providing member access for each object.  
  
 [!code[CsLINQGettingStarted#12](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_2.cs)]  
  
## Execute the Query  
  
#### To execute the query  
  
1.  Now write the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> loop that will cause the query to execute. Note the following about the code:  
  
    -   Each element in the returned sequence is accessed through the iteration variable in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> loop.  
  
    -   The type of this variable is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, and the type of the query variable is compatible, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
2.  After you have added this code, build and run the application to see the results in the **Console** window.  
  
 [!code[CsLINQGettingStarted#13](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_3.cs)]  
  
#### To add another filter condition  
  
1.  You can combine multiple Boolean conditions in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> clause in order to further refine a query. The following code adds a condition so that the query returns those students whose first score was over 90 and whose last score was less than 80. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> clause should resemble the following code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     For more information, see [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md).  
  
## Modify the Query  
  
#### To order the results  
  
1.  It will be easier to scan the results if they are in some kind of order. You can order the returned sequence by any accessible field in the source elements. For example, the following <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> clause orders the results in alphabetical order from A to Z according to the last name of each student. Add the following <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause to your query, right after the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> statement and before the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Now change the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> clause so that it orders the results in reverse order according to the score on the first test, from the highest score to the lowest score.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Change the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> format string so that you can see the scores:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     For more information, see [orderby clause (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).  
  
#### To group the results  
  
1.  Grouping is a powerful capability in query expressions. A query with a group clause produces a sequence of groups, and each group itself contains a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and a sequence that consists of all the members of that group. The following new query groups the students by using the first letter of their last name as the key.  
  
     [!code[CsLINQGettingStarted#14](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_4.cs)]  
  
2.  Note that the type of the query has now changed. It now produces a sequence of groups that have a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> type as a key, and a sequence of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects. Because the type of the query has changed, the following code changes the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> execution loop also:  
  
     [!code[CsLINQGettingStarted#15](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_5.cs)]  
  
3.  Run the application and view the results in the **Console** window.  
  
     For more information, see [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).  
  
#### To make the variables implicitly typed  
  
1.  Explicitly coding <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> can quickly become tedious. You can write the same query and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> loop much more conveniently by using <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> keyword does not change the types of your objects; it just instructs the compiler to infer the types. Change the type of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and the iteration variable <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and rerun the query. Note that in the inner <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> loop, the iteration variable is still typed as <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, and the query works just as before. Change the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> iteration variable to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and run the query again. You see that you get exactly the same results.  
  
     [!code[CsLINQGettingStarted#16](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_6.cs)]  
  
     For more information about [var](../vs140/var--csharp-reference-.md), see [Implicitly Typed Local Variables and Arrays (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md).  
  
#### To order the groups by their key value  
  
1.  When you run the previous query, you notice that the groups are not in alphabetical order. To change this, you must provide an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> clause after the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> clause. But to use an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> clause, you first need an identifier that serves as a reference to the groups created by the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> clause. You provide the identifier by using the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> keyword, as follows:  
  
     [!code[csLINQGettingStarted#17](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_7.cs)]  
  
     When you run this query, you will see the groups are now sorted in alphabetical order.  
  
#### To introduce an identifier by using let  
  
1.  You can use the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> keyword to introduce an identifier for any expression result in the query expression. This identifier can be a convenience, as in the following example, or it can enhance performance by storing the results of an expression so that it does not have to be calculated multiple times.  
  
     [!code[csLINQGettingStarted#18](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_8.cs)]  
  
     For more information, see [let (C# Reference)](../vs140/let-clause--csharp-reference-.md).  
  
#### To use method syntax in a query expression  
  
1.  As described in [Query Syntax versus Method Syntax (LINQ)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md), some query operations can only be expressed by using method syntax. The following code calculates the total score for each <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> in the source sequence, and then calls the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method on the results of that query to calculate the average score of the class. Note the placement of parentheses around the query expression.  
  
     [!code[csLINQGettingStarted#19](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_9.cs)]  
  
#### To transform or project in the select clause  
  
1.  It is very common for a query to produce a sequence whose elements differ from the elements in the source sequences. Delete or comment out your previous query and execution loop, and replace it with the following code. Note that the query returns a sequence of strings (not <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>), and this fact is reflected in the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> loop.  
  
     [!code[csLINQGettingStarted#20](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_10.cs)]  
  
2.  Code earlier in this walkthrough indicated that the average class score is approximately 334. To produce a sequence of <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> whose total score is greater than the class average, together with their <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, you can use an anonymous type in the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> statement:  
  
     [!code[csLINQGettingStarted#21](../vs140/codesnippet/CSharp/walkthrough--writing-queries-in-csharp--linq-_11.cs)]  
  
## Next Steps  
 After you are familiar with the basic aspects of working with queries in C#, you are ready to read the documentation and samples for the specific type of LINQ provider you are interested in:  
  
 [LINQ to SQL](assetId:///73d13345-eece-471a-af40-4cc7a2f11655)  
  
 [LINQ to DataSet](assetId:///743e3755-3ecb-45a2-8d9b-9ed41f0dcf17)  
  
 [LINQ to XML (C#)](../vs140/linq-to-xml--csharp-.md)  
  
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)  
  
## See Also  
 [Language-Integrated Query (LINQ) (C#)](../vs140/language-integrated-query--linq---csharp-.md)   
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)