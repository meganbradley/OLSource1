---
title: "CDumpContext Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDumpContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDumpContext class"
  - "AfxDump object"
  - "diagnostics, diagnostic classes"
  - "diagnostic classes"
  - "diagnosis, diagnostic classes"
ms.assetid: 98c52b2d-14b5-48ed-b423-479a4d1c60fa
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDumpContext Class
Supports stream-oriented diagnostic output in the form of human-readable text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDumpContext::CDumpContext](#cdumpcontext__cdumpcontext)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDumpContext::DumpAsHex](#cdumpcontext__dumpashex)|Dumps the indicated item in hexadecimal format.|  
|[CDumpContext::Flush](#cdumpcontext__flush)|Flushes any data in the dump context buffer.|  
|[CDumpContext::GetDepth](#cdumpcontext__getdepth)|Gets an integer corresponding to the depth of the dump.|  
|[CDumpContext::HexDump](#cdumpcontext__hexdump)|Dumps bytes contained in an array in hexadecimal format.|  
|[CDumpContext::SetDepth](#cdumpcontext__setdepth)|Sets the depth of the dump.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CDumpContext::operator<<](#cdumpcontext__operator__lt__lt_)|Inserts variables and objects into the dump context.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not have a base class.  
  
 You can use [afxDump](../vs140/afxdump--cdumpcontext-in-mfc-.md), a predeclared <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object, for most of your dumping. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object is available only in the Debug version of the Microsoft Foundation Class Library.  
  
 Several of the memory [diagnostic services](../vs140/diagnostic-services.md) use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for their output.  
  
 Under the Windows environment, the output from the predefined <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, conceptually similar to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> stream, is routed to the debugger via the Windows function **OutputDebugString**.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class has an overloaded insertion ( **<<**) operator for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointers that dumps the object's data. If you need a custom dump format for a derived object, override [CObject::Dump](../vs140/cobject-class.md#cobject__dump). Most Microsoft Foundation classes implement an overridden <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member function.  
  
 Classes that are not derived from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, such as <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, have their own overloaded <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> insertion operators, as do often-used structures such as **CFileStatus**, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 If you use the [IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md) or [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro in the implementation of your class, then <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> will print the name of your <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>-derived class. Otherwise, it will print <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class is available with both the Debug and Release versions of the library, but the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function is defined only in the Debug version. Use **#ifdef _DEBUG** / <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> statements to bracket your diagnostic code, including your custom <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> member functions.  
  
 Before you create your own <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object, you must create a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object that serves as the dump destination.  
  
 For more information on <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, see [Debugging MFC Applications](../vs140/mfc-debugging-techniques.md).  
  
 **#define _DEBUG**  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afx.h  
  
##  \<a name="cdumpcontext__cdumpcontext">\</a>  CDumpContext::CDumpContext  
 Constructs an object of class <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object that is the dump destination.  
  
### Remarks  
 The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object is constructed automatically.  
  
 Do not write to the underlying <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> while the dump context is active; otherwise, you will interfere with the dump. Under the Windows environment, the output is routed to the debugger via the Windows function **OutputDebugString**.  
  
### Example  
 [!code[NVC_MFC_Utilities#12](../vs140/codesnippet/CPP/cdumpcontext-class_1.cpp)]  
  
##  \<a name="cdumpcontext__dumpashex">\</a>  CDumpContext::DumpAsHex  
 Dumps the specified type formatted as hexadecimal numbers.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A reference to a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Call this member function to dump the item of the specified type as a hexadecimal number. To dump an array, call [CDumpContext::HexDump](#cdumpcontext__hexdump).  
  
### Example  
  [!code[NVC_MFC_Utilities#13](../vs140/codesnippet/CPP/cdumpcontext-class_2.cpp)]  
  
##  \<a name="cdumpcontext__flush">\</a>  CDumpContext::Flush  
 Forces any data remaining in buffers to be written to the file attached to the dump context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFC_Utilities#14](../vs140/codesnippet/CPP/cdumpcontext-class_3.cpp)]  
  
##  \<a name="cdumpcontext__getdepth">\</a>  CDumpContext::GetDepth  
 Determines whether a deep or shallow dump is in process.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The depth of the dump as set by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [SetDepth](#cdumpcontext__setdepth).  
  
##  \<a name="cdumpcontext__hexdump">\</a>  CDumpContext::HexDump  
 Dumps an array of bytes formatted as hexadecimal numbers.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *lpszLine*  
 A string to output at the start of a new line.  
  
 *pby*  
 A pointer to a buffer containing the bytes to dump.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The number of bytes to dump.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Maximum number of bytes dumped per line (not the width of the output line).  
  
### Remarks  
 To dump a single, specific item type as a hexadecimal number, call [CDumpContext::DumpAsHex](#cdumpcontext__dumpashex).  
  
### Example  
  [!code[NVC_MFC_Utilities#15](../vs140/codesnippet/CPP/cdumpcontext-class_4.cpp)]  
  
##  \<a name="cdumpcontext__operator__lt__lt_">\</a>  CDumpContext::operator &lt;&lt;  
 Outputs the specified data to the dump context.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> reference. Using the return value, you can write multiple insertions on a single line of source code.  
  
### Remarks  
 The insertion operator is overloaded for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> pointers as well as for most primitive types. A pointer to character results in a dump of string contents; a pointer to <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> results in a hexadecimal dump of the address only. A **LONGLONG** results in a dump of a 64-bit signed integer; A **ULONGLONG** results in a dump of a 64-bit unsigned integer.  
  
 If you use the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> macro in the implementation of your class, then the insertion operator, through <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, will print the name of your <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>-derived class. Otherwise, it will print <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. If you override the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> function of the class, then you can provide a more meaningful output of the object's contents instead of a hexadecimal dump.  
  
### Example  
 [!code[NVC_MFC_Utilities#17](../vs140/codesnippet/CPP/cdumpcontext-class_5.cpp)]  
  
##  \<a name="cdumpcontext__setdepth">\</a>  CDumpContext::SetDepth  
 Sets the depth for the dump.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *nNewDepth*  
 The new depth value.  
  
### Remarks  
 If you are dumping a primitive type or simple <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> that contains no pointers to other objects, then a value of 0 is sufficient. A value greater than 0 specifies a deep dump where all objects are dumped recursively. For example, a deep dump of a collection will dump all elements of the collection. You may use other specific depth values in your derived classes.  
  
> [!NOTE]
>  Circular references are not detected in deep dumps and can result in infinite loops.  
  
### Example  
 [!code[NVC_MFC_Utilities#16](../vs140/codesnippet/CPP/cdumpcontext-class_6.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile](../vs140/cfile-class.md)   
 [CObject](../vs140/cobject-class.md)