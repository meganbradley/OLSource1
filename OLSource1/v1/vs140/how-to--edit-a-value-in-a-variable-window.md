---
title: "How to: Edit a Value in a Variable Window"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Watch window, editing values"
  - "debugging [Visual Studio], editing expressions"
  - "variables [debugger], editing"
  - "expressions [debugger], editing"
  - "registers, editing"
ms.assetid: 36f464ab-c900-4c0b-9ab3-557b3d9cdab5
caps.latest.revision: 34
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Edit a Value in a Variable Window
The variable windows, **Autos**, **Locals**, and **Watch,** display the values of certain variables during a debugging session. The **QuickWatch** dialog box can also display variables. When the debugger is in break mode, you can use the variable windows to edit the values of most variables that appear in these locations.  
  
> [!NOTE]
>  Editing floating-point values can result in minor inaccuracies because of decimal-to-binary conversion of fractional components. Even a seemingly harmless edit can result in changes to some of the least significant bits in the floating-point variable.  
  
 When an expression is evaluated in the Watch window, you might see a refresh icon. This indicates an error or out-of-date value. For more information, see [How to: Refresh Watch Values](../vs140/refresh-watch-values.md).  
  
 If you want to, you can enter an expression for a value. The debugger will evaluate the expression and replace it with the resulting value. The debugger accepts most valid language expressions in a **Watch** window. For more information, see [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md).  
  
 If you are programming in native code, you might sometimes have to qualify the context of a variable name or an expression that contains a variable name. The context means the function, source file, and module where a variable is located. If you have to do this, you can use the context operator syntax.  
  
 Evaluating some expressions can change the value of a variable or otherwise affect the state of your program. For example, evaluating the following expression changes the value of `var1` and `var2`:  
  
```  
var1 = var2++  
```  
  
 Expressions that change data are said to have side effects, which can produce unexpected results if you are not aware of them. Therefore, make sure you understand the effect of an expression before you execute it.  
  
### To edit a value in a variable window or in QuickWatch  
  
1.  The debugger must be in break mode.  
  
2.  If the variable is an array or an object, a tree control appears next to the name in the **Name** box. In the **Name** column, expand the variable, if necessary, to find the element whose value that you want to edit.  
  
3.  In the row you want to change, double-click the **Value** column.  
  
4.  Type the new value.  
  
5.  Press **ENTER**.  
  
## See Also  
 [How to: Use Debugger Variable Windows](../vs140/autos-and-locals-windows.md)   
 [Debugger Variable Windows](../vs140/variable-windows.md)