---
title: Breakpoints Window
ms.custom: na
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: bad88d10-fdd5-4d3d-b5ea-a4f063847485
---
# Breakpoints Window
  The **Breakpoints** window lists all the breakpoints that are set in the current [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] Query Editor. To manage the breakpoints, use the toolbar in the **Breakpoints** window. Breakpoints are locations in the code where execution pauses in debug mode so that you can view debugging data.  
  
## Task List  
 **To access the Breakpoints window**  
  
-   On the **Debug** menu, click **Windows**, and then click **Breakpoints**.  
  
## Breakpoints Window Columns  
 By default, the **Breakpoints** window lists the following columns.  
  
 **Name**  
 Displays the name of the breakpoint. Breakpoint names are provided by the debugger. This name includes the name of Database Engine Query Editor window that contains the breakpoint, and the line number in the Query Editor on which the breakpoint is set.  
  
 **Condition**  
 Displays **\(no condition\)**. The [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] debugger does not support setting breakpoint conditions.  
  
 **Hit Count**  
 Displays**breaks always**.  
  
 You can add and remove the following columns by selecting them on the **Columns** list.  
  
 **Filter**  
 Displays **\(none\)**. The [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] debugger does not support setting breakpoint filters.  
  
 **When Hit**  
 Displays **Break**.  
  
 **Language**  
 Displays **Transact\-SQL** for [!INCLUDE[tsql](../../Token\Other/tsql_md.md)].  
  
 **Function**  
 Displays the number of the line on which the breakpoint is set.  
  
 **File**  
 Displays the name of the source file that contains the breakpoint, and the number of the line on which the breakpoint is set.  
  
 **Address**  
 The [!INCLUDE[tsql](../../Token\Other/tsql_md.md)] debugger does not support this feature.  
  
 **Process**  
 Displays **\[SQL\]** to indicate that this is a [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] process. This is followed by the name of the instance of the [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] in which the code executes.  
  
## Breakpoints Window Toolbar  
 When the current [!INCLUDE[ssDE](../../Token\Other/ssDE_md.md)] Query Editor window has active breakpoints, the **Breakpoints** window displays a toolbar that can be used to manage the breakpoints.  
  
 **Delete**  
 Deletes the selected breakpoint.  
  
 **Delete All Breakpoints**  
 Deletes all breakpoints that are displayed in the **Breakpoints** window.  
  
 **Disable All Breakpoints**  
 Disables all breakpoints so that they no longer stop code execution; however, the breakpoints remain. When all the breakpoints are disabled, this button becomes **Enable All Breakpoints**.  
  
 **Enable All Breakpoints**  
 Enables all breakpoints so that they stop code execution. When all breakpoints are enabled, this button becomes **Disable All Breakpoints**.  
  
 **Go To Source Code**  
 Positions the cursor on the line in the Query Editor that contains the selected breakpoint.  
  
 **Columns**  
 Lists all the columns that can be displayed in the **Breakpoints** window. A check box indicates the columns that are displayed. To add or remove a column in the **Breakpoints** window, select the column on the list.  
  
## See Also  
 [Transact-SQL Debugger](../../Topics\TopicNameNotContainA/Transact-SQL-Debugger.md)  
  
  