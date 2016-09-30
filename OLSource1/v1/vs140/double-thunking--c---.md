---
title: "Double Thunking (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "double thunks"
  - "interop [C++], double thunking"
  - "mixed assemblies [C++], double thunking"
  - "/clr compiler option [C++], double thunking"
  - "interoperability [C++], double thunking"
ms.assetid: a85090b2-dc3c-498a-b40c-340db229dd6f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Double Thunking (C++)
Double thunking refers to the loss of performance you can experience when a function call in a managed context calls a Visual C++ managed function and where program execution calls the function's native entry point in order to call the managed function. This topic discusses where double thunking occurs and how you can avoid it to improve performance.  
  
## Remarks  
 By default, when compiling with **/clr** (not **/clr:pure**), the definition of a managed function causes the compiler to generate a managed entry point and a native entry point. This allows the managed function to be called from native and managed call sites. However, when a native entry point exists, it can be the entry point for all calls to the function. If a calling function is managed, the native entry point will then call the managed entry point. In effect, two calls are required to invoke the function (hence, double thunking). For example, virtual functions are always called through a native entry point.  
  
 One resolution is to tell the compiler not to generate a native entry point for a managed function, that the function will only be called from a managed context, by using the [__clrcall](../vs140/__clrcall.md) calling convention.  
  
 Similarly, if you export ([dllexport, dllimport](../vs140/dllexport--dllimport.md)) a managed function, a native entry point is generated and any function that imports and calls that function will call through the native entry point. To avoid double thunking in this situation, do not use native export/import semantics; simply reference the metadata via <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (see [The #using Directive](../vs140/sharpusing-directive--c---.md)).  
  
 The compiler has been updated to reduce unnecessary double thunking. For example, any function with a managed type in the signature (including return type) will implicitly be marked as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information on double thunk elimination, see [http://msdn.microsoft.com/msdnmag/issues/05/01/COptimizations/default.aspx](http://msdn.microsoft.com/msdnmag/issues/05/01/COptimizations/default.aspx).  
  
## Example  
  
### Description  
 The following sample demonstrates double thunking. When compiled native (without **/clr**), the call to the virtual function in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> generates one call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>'s copy constructor and one call to the destructor. Similar behavior is achieved when the virtual function is declared with **/clr** and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. However, when just compiled with **/clr**, the function call generates a call to the copy constructor but there is another call to the copy constructor due to the native-to-managed thunk.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Sample Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The previous sample demonstrated the existence of double thunking. This sample shows its effect. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> loop calls the virtual function and the program reports execution time. The slowest time is reported when the program is compiled with **/clr**. The fastest times are reported when compiling without **/clr** or if the virtual function is declared with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Mixed Assemblies](../vs140/mixed--native-and-managed--assemblies.md)