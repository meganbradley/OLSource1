---
title: "Create custom views of .managed objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.data.elements"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "data types [C#], custom"
  - "custom data types"
  - "managed code, custom data types"
  - "autoexp.dat file"
  - "mcee_cs.dat file"
  - "debugger, expanding data types"
  - "mcee_mc.dat file"
ms.assetid: 9969e9b2-9008-4729-8a14-0d6deaa61576
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Create custom views of .managed objects
You can customize the way Visual Studio displays data types in debugger variable windows.  
  
## Attributes  
 In C# and Visual Basic, you can add expansions for custom data using <xref:System.Diagnostics.DebuggerTypeProxyAttribute*>, <xref:System.Diagnostics.DebuggerDisplayAttribute*>, and <xref:System.Diagnostics.DebuggerBrowsableAttribute*>.  
  
 In [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)] code, Visual Basic does not support the DebuggerBrowsable attribute. This limitation is removed in more recent versions of the .NET Framework.  
  
## Visualizers  
 You can write a visualizer to display any managed data type. For more information, see [How to: Write a Visualizer](../vs140/how-to--write-a-visualizer.md).  
  
## Native Code  
 For native code, you can add custom data type expansions to the file autoexp.dat, which is located in the Program Files\Microsoft Visual Studio 11.0\Common7\Packages\Debugger directory. Instructions on how to write `autoexp` rules are located in the file itself.  
  
> [!CAUTION]
>  The structure of this file and the syntax of autoexp rules might change from one release of Visual Studio to the next.  
  
 Native type views can also be customized by writing an expression evaluator add-in. For more information, see [EEAddIn Sample: Debugging Expression Evaluator Add-In](assetId:///d4f6b068-c812-45bc-9ec0-7e0363c4bb9e).  
  
## See Also  
 [Using DebuggerTypeProxy Attribute](../vs140/using-debuggertypeproxy-attribute.md)   
 [Using DebuggerDisplay Attribute](../vs140/using-the-debuggerdisplay-attribute.md)   
 [How to: Watch an Expression in the Debugger](../vs140/watch-and-quickwatch-windows.md)   
 [How to: Enhance Debugging with the Debugger Display Attributes](assetId:///72bb7aa9-459b-42c4-9163-9312fab4c410)