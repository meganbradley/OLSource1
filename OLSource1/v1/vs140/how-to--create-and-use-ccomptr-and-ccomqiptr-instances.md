---
title: "How to: Create and Use CComPtr and CComQIPtr Instances"
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
ms.assetid: b0356cfb-12cc-4ee8-b988-8311ed1ab5e0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create and Use CComPtr and CComQIPtr Instances
In classic Windows programming, libraries are often implemented as COM objects (or more precisely, as COM servers). Many Windows operating system components are implemented as COM servers, and many contributors provide libraries in this form. For information about the basics of COM, see [Component Object Model (COM)](assetId:///3578ca42-a4b6-44b3-ad5b-aeb5fa61f3f4).  
  
 When you instantiate a Component Object Model (COM) object, store the interface pointer in a COM smart pointer, which performs the reference counting by using calls to <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the destructor. If you are using the Active Template Library (ATL) or the Microsoft Foundation Class Library (MFC), then use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> smart pointer. If you are not using ATL or MFC, then use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Because there is no COM equivalent to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, use these smart pointers for both single-owner and multiple-owner scenarios. Both <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> support move operations that have rvalue references.  
  
## Example  
 The following example shows how to use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to instantiate a COM object and obtain pointers to its interfaces. Notice that the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function is used to create the COM object, instead of the Win32 function that has the same name.  
  
 [!code[COM_smart_pointers#01](../vs140/codesnippet/CPP/how-to--create-and-use-ccomptr-and-ccomqiptr-instances_1.cpp)]  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and its relatives are part of the ATL and are defined in atlcomcli.h. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is declared in comip.h. The compiler creates specializations of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when it generates wrapper classes for type libraries.  
  
## Example  
 ATL also provides <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, which has a simpler syntax for querying a COM object to retrieve an additional interface. However, we recommend <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> because it does everything that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can do and is semantically more consistent with raw COM interface pointers. If you use a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to query for an interface, the new interface pointer is placed in an out parameter. If the call fails, an HRESULT is returned, which is the typical COM pattern. With <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the return value is the pointer itself, and if the call fails, the internal HRESULT return value cannot be accessed. The following two lines show how the error handling mechanisms in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> differ.  
  
 [!code[COM_smart_pointers#02](../vs140/codesnippet/CPP/how-to--create-and-use-ccomptr-and-ccomqiptr-instances_2.cpp)]  
  
## Example  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> provides a specialization for IDispatch that enables it to store pointers to COM automation components and invoke the methods on the interface by using late binding. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a typedef for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, which is implicitly convertible to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Therefore, when any of these three names appears in code, it is equivalent to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The following example shows how to obtain a pointer to the Microsoft Word object model by using a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 [!code[COM_smart_pointers#03](../vs140/codesnippet/CPP/how-to--create-and-use-ccomptr-and-ccomqiptr-instances_3.cpp)]  
  
## See Also  
 [Smart Pointers](../vs140/smart-pointers--modern-c---.md)