---
title: "Boxing  (C++ Component Extensions)"
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
  - "boxing, Visual C++"
ms.assetid: b5fd2c98-c578-4f83-8257-6dd663478665
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boxing  (C++ Component Extensions)
The Visual C++ compiler can convert value types to objects in a process called *boxing*, and convert objects to value types in a process called *unboxing*.  
  
## All Runtimes  
 (There are no remarks for this language feature that apply to all runtimes.)  
  
## Windows Runtime  
 [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)] supports a shorthand syntax for boxing value types and unboxing reference types. A value type is boxed when it is assigned to a variable of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. An <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable is unboxed when it is assigned to a value type variable and the unboxed type is specified in parentheses; that is, when the object variable is cast to a value type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Requirements  
 Compiler option: **/ZW**  
  
### Examples  
 The following code example boxes and unboxes a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value. First, the example obtains a DateTime value that represents the current date and time and assigns it to a DateTime variable. Then the DateTime is boxed by assigning it to an Object variable. Finally, the boxed value is unboxed by assigning it to another DateTime variable.  
  
 To test the example, create a BlankApplication project, replace the BlankPage::OnNavigatedTo() method, and then specify breakpoints at the closing bracket and the assignment to variable str1. When the example reaches the closing bracket, examine str1.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information, see [Boxing (C++/CX)](http://msdn.microsoft.com/library/windows/apps/hh969554.aspx).  
  
## Common Language Runtime  
 The Visual C++ compiler now boxes value types to \<xref:System.Object*>.  This is possible because of a compiler-defined conversion to convert value types to \<xref:System.Object*>.  
  
 Boxing and unboxing enable value types to be treated as objects. Value types, including both struct types and built-in types such as int, can be converted to and from the type \<xref:System.Object*>.  
  
 For more information, see:  
  
-   [How to: Explicitly Request Boxing](../vs140/how-to--explicitly-request-boxing.md)  
  
-   [How to: Use gcnew to Create Value Types and Use Implicit Boxing](../vs140/how-to--use-gcnew-to-create-value-types-and-use-implicit-boxing.md)  
  
-   [How to: Unboxing](../vs140/how-to--unbox.md)  
  
-   [Standard Conversions and Implicit Boxing](../vs140/standard-conversions-and-implicit-boxing.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following sample shows how implicit boxing works.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **1**   
 **xx = 10**   
 **in A**   
 **Class V passed using implicit boxing**   
 **Class V passed with forced boxing**   
 **Interface function**   
 **in func1(V2^)**   
 **in func2(System::ValueType^)**   
 **in func2(System::ValueType^)**   
## See Also  
 [Component Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)