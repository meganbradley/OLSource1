---
title: Integration Services (SSIS) Expressions
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - integration-services
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 26d2e242-7f60-4fa9-a70d-548a80eee667
---
# Integration Services (SSIS) Expressions
  An expression is a combination of symbols—identifiers, literals, functions, and operators—that yields a single data value. Simple expressions can be a single constant, variable, or function. More frequently, expressions are complex, using multiple operators and functions and referencing multiple columns and variables. In [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)], expressions can be used to define conditions for CASE statements, create and update values in data columns, assign values to variables, update or populate properties at run time, define constraints in precedence constraints, and provide the expressions used by the For Loop container.  
  
 Expressions are based on an expression language, and the expression evaluator. The expression evaluator parses the expression and determines whether the expression follows the rules of the expression language. For more information about the expression syntax and supported literals and identifiers, see the following topics.  
  
-   [Syntax &#40;SSIS&#41;](../Topic/Syntax%20\(SSIS\).md)  
  
-   [Literals &#40;SSIS&#41;](../Topic/Literals%20\(SSIS\).md)  
  
-   [Identifiers &#40;SSIS&#41;](../Topic/Identifiers%20\(SSIS\).md)  
  
## Components that Use Expressions  
 The following elements in [!INCLUDE[ssISnoversion](../../Token\Other/ssISnoversion_md.md)] can use expressions:  
  
-   The Conditional Split transformation implements a decision structure based on expressions to direct data rows to different destinations. Expressions used in a Conditional Split transformation must evaluate to **true** or **false**. For example, rows that meet the condition in the expression "Column1 \> Column2" can be routed to a separate output.  
  
-   The Derived Column transformation uses values created by using expressions either to populate new columns in a data flow, or to update existing columns. For example, the expression Column1 \+ " ABC" can be used to update a value or to create a new value with the concatenated string.  
  
-   Variables use an expression to set their value. For example, GETDATE\(\) sets the value of the variable to the current date.  
  
-   Precedence constraints can use expressions to specify the conditions that determine whether the constrained task or container in a package runs. Expressions used in a precedence constraint must evaluate to **true** or **false**. For example, the expression @A \> @B compares two user\-defined variables to determine whether the constrained task runs.  
  
-   The For Loop container can use expressions to build the initialization, evaluation, and the incrementing statements that the looping structure uses. For example, the expression @Counter \= 1 initializes the loop counter.  
  
 Expressions can also be used to update the values of properties of packages, containers such as the For Loop and Foreach Loop, tasks, package and project level connection managers, log providers, and Foreach enumerators. For example, using a property expression, the string "Localhost.AdventureWorks" can be assigned to the ConnectionName property of the Execute SQL task. For more information, see [Use Property Expressions in Packages](../../Topics\TopicNameNotContainA/Use-Property-Expressions-in-Packages.md).  
  
## Icon Markers for Expressions  
 In [!INCLUDE[ssBIDevStudioFull](../../Token\Other/ssBIDevStudioFull_md.md)], a special icon marker displays next to connection managers, variables, and tasks that have expressions set on them. The **HasExpressions** property is available on all SSIS objects that support expresions, with the exception of variables. The property enables you to easily identy which objects have expressions.  
  
## Expression Builder  
 The expression builder is a graphical tool for building expressions. It is available in the **Conditional Split Transformation Editor**, **Derived Column Transformation Editor** dialog boxes, and in the **Expression Builder** dialog box, is a graphical tool for building expressions.  
  
 The expression builder provides folders that contain package\-specific elements, and folders that contain the functions, type casts, and operators that the expression language provides. The package\-specific elements include system variables and user\-defined variables. In the **Conditional Split Transformation Editor** and **Derived Column Transformation Editor** dialog boxes, you can also view data columns. To build expressions for the transformations, you can drag items from the folders to the **Condition** or **Expression** column or you can type the expression directly in the column. The expression builder automatically adds needed syntax elements such as the @ prefix on variable names.  
  
> [!NOTE]  
>  The names of user\-defined and system variables are case\-sensitive.  
  
 Variables have scope, and the **Variables** folder in the expression builder lists only variables that are in scope and available to use. For more information, see [Integration Services &#40;SSIS&#41; Variables](../Topic/Integration%20Services%20\(SSIS\)%20Variables.md).  
  
## Related Tasks  
 [Use an Expression in a Data Flow Component](../../Topics\TopicNameContainA/Use-an-Expression-in-a-Data-Flow-Component.md)  
  
## Related Content  
 Technical article, [SSIS Expression Examples](http://go.microsoft.com/fwlink/?LinkId=220761), on social.technet.microsoft.com  
  
## See Also  
 [SQL Server Integration Services](../../Topics\TopicNameNotContainA/SQL-Server-Integration-Services.md)  
  
  