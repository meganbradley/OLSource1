---
title: "How to: Marshal a VARIANT for ADO.NET (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
H1: "How to: Marshal a VARIANT for ADO.NET (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VARIANT, marshaling"
  - "ADO.NET [C++], marshaling VARIANT types"
  - "VARIANT"
ms.assetid: 67a180a7-5691-48ab-8d85-7f75a68dde91
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Marshal a VARIANT for ADO.NET (C++-CLI)
Demonstrates how to add a native <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to a database and how to marshal a \<xref:System.Object*?displayProperty=fullName> from a database to a native <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 In this example, the class DatabaseClass is created to interact with an ADO.NET \<xref:System.Data.DataTable*> object. Note that this class is a native C++ <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (as compared to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). This is necessary because we want to use this class from native code, and you cannot use managed types in native code. This class will be compiled to target the CLR, as is indicated by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive preceding the class declaration. For more information on this directive, see [managed, unmanaged](../vs140/managed--unmanaged.md).  
  
 Note the private member of the DatabaseClass class: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Since native types cannot contain managed types, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is necessary. For more information on <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, see [Handles in Native Types](../vs140/how-to--declare-handles-in-native-types.md).  
  
 The rest of the code in this example is native C++ code, as is indicated by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directive preceding <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. In this example, we are creating a new instance of DatabaseClass and calling its methods to create a table and populate some rows in the table. Note that native <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> types are being passed as values for the database column ObjectCol. Inside DatabaseClass, these <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> types are marshaled to managed objects using the marshaling functionality found in the \<xref:System.Runtime.InteropServices*?displayProperty=fullName> namespace. Specifically, the method \<xref:System.Runtime.InteropServices.Marshal.GetObjectForNativeVariant*> is used to marshal a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to an \<xref:System.Object*>, and the method \<xref:System.Runtime.InteropServices.Marshal.GetNativeVariantForObject*> is used to marshal an \<xref:System.Object*> to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **ObjectCol: This is a BSTR in a VARIANT.**  
**ObjectCol: 42**   
## Compiling the Code  
  
-   To compile the code from the command line, save the code example in a file named adonet_marshal_variant.cpp and enter the following statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## .NET Framework Security  
 For information on security issues involving ADO.NET, see [Securing ADO.NET Applications](assetId:///005a1d43-6ee5-471e-ad98-1d30a44d49d5).  
  
## See Also  
 \<xref:System.Runtime.InteropServices*>   
 [Data Access Using ADO.NET in C++](../vs140/data-access-using-ado.net--c---cli-.md)   
 [ADO.NET](assetId:///5b96ed06-9759-4966-a797-a1d5f6ee50ca)   
 [Interoperability](assetId:///afcc2e7d-3f32-48d2-8141-1c42acf29084)   
 [Native and .NET Interoperability](../vs140/native-and-.net-interoperability.md)