---
title: "new (new slot in vtable)  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "new keyword [C++]"
ms.assetid: 1a9a5704-f02f-46ae-ad65-f0f2b6dbabc3
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# new (new slot in vtable)  (C++ Component Extensions)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword indicates that a virtual member will get a new slot in the vtable.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword has many uses and meanings. For more information, see the disambiguation topic [new](../vs140/new.md).  
  
## All Runtimes  
 (There are no remarks for this language feature that apply to all runtimes.)  
  
## Windows Runtime  
 Not supported in [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Remarks**  
  
 In a **/clr** compilation, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> indicates that a virtual member will get a new slot in the vtable; that the function does not override a base class method.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> causes the newslot modifier to be added to the IL for the function.  For more information about newslot, see:  
  
-   [MethodInfo.GetBaseDefinition Method](https://msdn.microsoft.com/en-us/library/system.reflection.methodinfo.getbasedefinition.aspx)  
  
-   [MethodAttributes Enumeration](https://msdn.microsoft.com/en-us/library/system.reflection.methodattributes.aspx)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following sample shows the effect of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **C::f() called**   
 **D::f() called**   
 **D::g() called**   
 **D::g() called**   
 **E::f() called**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)   
 [Override Specifiers](../vs140/override-specifiers---c---component-extensions-.md)