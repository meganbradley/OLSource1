---
title: "Defining Stored Procedures"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stored procedures, syntax"
  - "OLE DB, stored procedures"
  - "stored procedures, defining"
  - "stored procedures, OLE DB"
ms.assetid: 54949b81-3275-4dd9-96e4-3eda1ed755f2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Defining Stored Procedures
Before calling a stored procedure, you must first define it, using the [DEFINE_COMMAND](../vs140/define_command.md) macro. When you define the command, denote parameters with a question mark (?) as the parameter marker:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Note that the syntax (the use of braces and so on) used in the code examples in this topic is specific to SQL Server. The syntax that you use in your stored procedures might vary according to the provider you use.  
  
 Next, in the parameter map, specify the parameters that you used in the command, listing the parameters in the order that they occur in the command:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The previous example defines a stored procedure as it goes. Typically, for efficient reuse of code, a database contains a set of predefined stored procedures with names such as "Sales by Year" or "dt_adduserobject." You can view their definitions using SQL Server Enterprise Manager. You call them as follows (the placement of the '?' parameters depends on the stored procedure's interface):  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Next, declare the command class:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Finally, call the stored procedure in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as follows:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Also note that you can define a stored procedure using the database attribute [db_command](../vs140/db_command.md) as follows:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Using Stored Procedures](../vs140/using-stored-procedures.md)