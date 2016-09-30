---
title: "Dynamic View"
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
helpviewer_keywords: 
  - "Dynamic View debugging"
  - "debugging, Dynamic View"
ms.assetid: 4c851b17-2c12-46a0-9828-eb6ea6f5c563
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dynamic View
This feature applies only to projects that use .NET Framework version 4.  
  
 When the **Watch** window displays an object that implements the `IDynamicMetaObjectProvider` interface, the debugger adds a special **Dynamic View** node to the watch display. The Dynamic View node shows members of the dynamic object but does not allow editing of the member values.  
  
 If you right-click any child of a Dynamic View and choose **Add to Watch**, the debugger inserts a new watch variable that casts for object to a dynamic object. In other words, `object Name` becomes:  
  
```  
((dynamic)object.Name  
```  
  
 Evaluating the members of a Dynamic View can have side effects. For C#, the debugger does not automatically reevaluate the values shown in the **Dynamic View** when you step to a new line of code. For Visual Basic, expressions added through the Dynamic View are automatically refreshed.  
  
 For instructions about how to refresh the **Dynamic View** values, see [How to: Refresh Watch Values](../vs140/refresh-watch-values.md). For an explanation of what side effects are, see [Side Effects and Expressions](../vs140/side-effects-and-expressions.md). For Visual Basic, values shown in the **Dynamic View** are automatically reevaluated.  
  
 If you want to display only the Dynamic View for an object, you can use the `dynamic` format specifier as shown here for C#:  
  
```  
ObjectName, dynamic  
```  
  
 For Visual Basic, you can use this syntax:  
  
```  
$dynamic, ObjectName  
```  
  
## COM Objects  
 The Dynamic View also enhances the debugging experience for COM objects. When the debugger encounters a COM object wrapped in the generic RCW, System.__ComObject, it adds a **Dynamic View** node for the object.  
  
## See Also  
 [How to: Watch an Expression in the Debugger](../vs140/watch-and-quickwatch-windows.md)