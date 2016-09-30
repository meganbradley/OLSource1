---
title: "typeid  (C++ Component Extensions)"
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
  - "typeid keyword [C++]"
ms.assetid: e9706cae-e7c4-4d6d-b474-646d73df3e70
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typeid  (C++ Component Extensions)
Gets a value that indicates the type of an object.  
  
> [!WARNING]
>  This topic refers to the C++ Component Extensions version of typeid. For the ISO C++ version of this keyword, see [typeid Operator](../vs140/typeid-operator.md).  
  
## All Runtimes  
  
### Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 *T*  
 A type name.  
  
## Windows Runtime  
  
### Syntax  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A type name.  
  
### Remarks  
 In [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)],  typeid returns a [Platform::Type](assetId:///d6b03f1e-b240-49b9-a08e-53a460030475) that is constructed from runtime type information.  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Syntax**  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *type*  
 The name of a type (abstract declarator) for which you want the System::Type object.  
  
 **Remarks**  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is used to get the \<xref:System.Type*> for a type at compile time.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is similar to getting the System::Type for a type at run time using \<xref:System.Type.GetType*> or \<xref:System.Object.GetType*>. However, typeid only accepts a type name as a parameter.  If you want to use an instance of a type to get its System::Type name, use GetType.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be able to evaluate a type name (type) at compile time, whereas GetType evaluates the type to return at run time.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can take a native type name or common language runtime alias for the native type name; see [.NET Framework Equivalents to C++ Native Types](../vs140/.net-framework-equivalents-to-c---native-types--c---cli-.md) for more information.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> also works with native types, although it will still return a System::Type.  To get a type_info structure, use [typeid Operator](../vs140/typeid-operator.md).  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the sucessor to [__typeof](../vs140/__typeof.md) in the previous **/clr** syntax.  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following example compares the typeid keyword to the GetType() member.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **typeid and GetType returned the same System::Type**  
**G**   
 **System.Single\***  **Example**  
  
 The following sample shows that a variable of type System::Type can be used to get the attributes on a type.  It also shows that for some types, you will have to create a typedef to use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **True**   
 **in AtClass2 constructor**   
 **in AtClass Type ^ constructor**   
 **AtClass2**   
 **System.AttributeUsageAttribute**   
 **AtClass**   
 **int::typeid != pointer_to_int::typeid, as expected**   
 **int::typeid == handle_to_int::typeid, as expected**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)