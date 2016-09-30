---
title: "conform"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "conform_CPP"
  - "vc-pragma.conform"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "conform pragma"
  - "forScope conform pragma"
  - "pragmas, conform"
ms.assetid: 71b3e174-c53c-4bfc-adf3-af39b1554191
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# conform
**C++ Specific**  
  
 Specifies the run-time behavior of the [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md) compiler option.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *name*  
 Specifies the name of the compiler option to be modified. The only valid *name* is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 **show** (optional)  
 Causes the current setting of *name* (true or false) to be displayed by means of a warning message during compilation. For example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 **on, off**(optional)  
 Setting *name* to **on** enables the [/Zc:forScope](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md) compiler option. The default is **off**.  
  
 **push** (optional)  
 Pushes the current value of *name* onto the internal compiler stack. If you specify *identifier*, you can specify the **on** or **off** value for *name* to be pushed onto the stack. For example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 **pop** (optional)  
 Sets the value of *name* to the value at the top of the internal compiler stack and then pops the stack. If identifier is specified with **pop**, the stack will be popped back until it finds the record with *identifier*, which will also be popped; the current value for *name* in the next record on the stack becomes the new value for *name*. If you specify pop with an *identifier* that is not in a record on the stack, the **pop** is ignored.  
  
 *identifier*(optional)  
 Can be included with a **push** or **pop** command. If *identifier* is used, then an **on** or **off** specifier can also be used.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)