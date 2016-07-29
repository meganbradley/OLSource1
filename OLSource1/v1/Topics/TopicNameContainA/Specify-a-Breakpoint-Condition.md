---
title: "Specify a Breakpoint Condition"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - database-engine
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b43d8a2b-99a3-4fb7-8848-99c042ea7ef7
caps.latest.revision: 7
manager: jhubbard
---
# Specify a Breakpoint Condition
A breakpoint condition is a [!INCLUDE[tsql](../../Topics/TopicNameContainA/includes/tsql_md.md)] expression that is evaluated by the debugger when the breakpoint is reached. If the condition is satisfied and any specified hit count reached, the debugger either breaks or performs the action specified for the breakpoint.  
  
## Specifying Conditions  
 The expression specified must be a valid Transact-SQL expression that evaluates to a Boolean value. For more information, see [Expressions (Transact-SQL)](assetId:///ee53c5c8-e36c-40f9-8cd1-d933791b98fa).  
  
 If you specify a breakpoint condition with invalid syntax, a warning message appears immediately. If you specify a condition with valid syntax but invalid semantics, a warning message is displayed the first time the breakpoint is hit. In either case, the debugger breaks execution when the invalid breakpoint is hit.  
  
#### To Specify a Condition  
  
1.  In the editor window, right-click the breakpoint glyph, and then click **Condition** on the shortcut menu.  
  
     -or-  
  
     In the **Breakpoints** window, right-click the breakpoint glyph, and then click **Condition** on the shortcut menu.  
  
2.  In the **Breakpoint Condition** dialog box, enter a valid Boolean expression in the **Condition** box.  
  
3.  Choose **Is true** if you want to break when the expression evaluates to **true**, or choose **Has changed** if you want to break when the value of the expression has changed.  
  
    > [!NOTE]  
    >  The debugger does not evaluate the Boolean expression until the first time the breakpoint is reached. If you choose **Has changed**, the debugger does not consider the first evaluation to be a change, so the debugger will not break on the first evaluation.  
  
## See Also  
 [Specify a Hit Count](../../Topics/TopicNameContainA/Specify-a-Hit-Count.md)   
 [Specify a Breakpoint Action](../../Topics/TopicNameContainA/Specify-a-Breakpoint-Action.md)