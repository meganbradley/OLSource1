---
title: "Exporting String Classes Using CStringT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringT class, exporting strings"
ms.assetid: bdfc441e-8d2a-461c-9885-46178066c09f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exporting String Classes Using CStringT
In the past, MFC developers have derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to specialize their own string classes. In Microsoft Visual C++.NET (MFC 8.0), the [CString](../vs140/using-cstring.md) class was superseded by a template class called [CStringT](../vs140/cstringt-class.md). This provided several benefits:  
  
-   It allowed the MFC <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class to be used in ATL projects without linking in the larger MFC static library or DLL.  
  
-   With the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> template class, you can customize <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> behavior using template parameters that specify character traits, similar to the templates in the Standard Template Library (STL).  
  
-   When you export your own string class from a DLL using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the compiler also automatically exports the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> base class. Since <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is itself a template class, it may be instantiated by the compiler when used, unless the compiler is aware that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is imported from a DLL. If you have migrated projects from Visual C++ 6.0 to Visual C++.NET, you might have seen linker symbol errors for a multiply-defined <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> because of the collision of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> imported from a DLL and the locally instantiated version. The proper way to do this is described below. For more information on this issue, see the Knowledge Base article, "Linking Errors When you Import CString-derived Classes" (Q309801) on the MSDN Library CD-ROM or at [http://support.microsoft.com/default.aspx](http://support.microsoft.com/default.aspx).  
  
 The following scenario will cause the linker to produce symbol errors for multiply defined classes. Assume that you are exporting a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>-derived class (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) from an MFC extension DLL:  
  
 [!code[NVC_MFC_DLL#6](../vs140/codesnippet/CPP/exporting-string-classes-using-cstringt_1.cpp)]  
  
 The consumer code uses a mixture of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. "MyString.h" is not included in the precompiled header, and some usage of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> does not have <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> visible.  
  
 Assume that you use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> classes in separate source files, Source1.cpp and Source2.cpp. In Source1.cpp, you use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and #include MyString.h. In Source2.cpp, you use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, but do not #include MyString.h. In this case, the linker will complain about <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> being multiply defined. This is caused by <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> being both imported from the DLL that exports <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and instantiated locally by the compiler through the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> template.  
  
 To resolve this problem, do the following:  
  
 Export <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (and the necessary base classes) from MFC90.DLL. Projects that include MFC will always use the MFC DLL exported <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, as in previous MFC implementations.  
  
 Then create a exportable derived class using the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> template, as <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is below, for example:  
  
 [!code[NVC_MFC_DLL#7](../vs140/codesnippet/CPP/exporting-string-classes-using-cstringt_2.cpp)]  
  
 In AfxStr.h, replace the previous <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> typedefs as follows:  
  
 [!code[NVC_MFC_DLL#8](../vs140/codesnippet/CPP/exporting-string-classes-using-cstringt_3.cpp)]  
  
 There are several caveats:  
  
-   You should not export <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> itself because this will cause ATL-only projects to export a specialized <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class.  
  
-   Using an exportable derived class from <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> minimizes having to re-implement <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> functionality. Additional code is limited to forwarding constructors to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> base class.  
  
-   <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> should only be marked <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> when you are building with an MFC shared DLL. If linking with an MFC static library, you should not mark these classes as exported; otherwise, internal use of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> inside user DLLs will mark <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> as exported as well.  
  
## Related Topics  
 [CStringT Class](../vs140/cstringt-class.md)  
  
## See Also  
 [Using CStringT](../vs140/using-cstringt.md)   
 [Using CString](../vs140/using-cstring.md)