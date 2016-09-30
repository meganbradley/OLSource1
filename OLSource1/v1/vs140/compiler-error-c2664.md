---
title: "Compiler Error C2664"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2664"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2664"
ms.assetid: 3595d66e-cf87-4fda-a896-c0cd81f95db4
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2664
'function' : cannot convert argument n from 'type1' to 'type2'  
  
 This parameter conversion problem might happen if an instance of a class is created and an implicit conversion is attempted on a constructor marked with the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword. For more information about explicit conversions, see [Conversions](../vs140/user-defined-type-conversions--c---.md).  
  
 If a temporary object is passed to a function that takes a reference to an object as a parameter, that reference must be a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> reference.  
  
 If the function is passed a parameter that is not of the type that the function expects, a temporary object is created by using the appropriate constructor. This temporary object is then passed to the function. In this case, the temporary object is used to initialize the reference. In earlier versions of the language, all references could be initialized by temporary objects.  
  
 To fix C2664,  
  
-   Recheck the prototype for the given function and correct the argument noted in the error message.  
  
-   Supply an explicit conversion if necessary.  
  
 C2664 can also be generated if a class hides a member in one of its base classes.  
  
 For more information, see [How to: Convert System::String to wchar_t* or char\*](../vs140/how-to--convert-system--string-to-wchar_t--or-char-.md).  
  
## Example  
 The following sample generates C2664 and shows how to fix it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This sample also generates C2664 and shows how to fix it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The next sample demonstrates C2664 by using a string literal to call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and shows how to fix it. Because the parameter is an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> reference, an object must be created by the appropriate constructor. The result is a temporary object that cannot be used to initialize the reference.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The compiler enforces the C++ standard requirements for applying <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This sample generates C2664:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 Here's a more complex situation where C2664 is generated, including directions on how to fix it:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Example  
 An enum variable is not converted to its underlying type such that a function call will be satisfied. For more information, see [enum class](../vs140/enum-class---c---component-extensions-.md). The following sample generates C2664 and shows how to fix it.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Example  
 A bug in the midl compiler causes a wchar_t type to be emitted as an unsigned short in the type library. To resolve this error, either cast the type in your C++ source code or define the type as a string in the idl file.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 C2664 is also raised by using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> when porting code from Visual C++ 6.0 to later versions. In Visual C++ 6.0 and earlier, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> was a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and was therefore implicitly convertible to that type. After Visual C++ 6.0, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is its own built-in type, as specified in the C++ standard, and is no longer implicitly convertible to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. See [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md).  
  
## Example  
 The following sample generates C2664 and shows how to fix it.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Example  
 C2664 is also caused if the compiler cannot deduce template arguments.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>