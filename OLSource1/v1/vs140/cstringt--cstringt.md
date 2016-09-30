---
title: "CStringT::CStringT"
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
  - "CStringT.CStringT"
  - "ATL::CStringT::CStringT"
  - "ATL.CStringT.CStringT"
  - "CStringT::CStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStringT constructor"
  - "CStringT class, constructor"
ms.assetid: a7618d52-b2e6-42a2-8716-b02f2c5b20d7
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::CStringT
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an array of characters of length <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, not null-terminated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A count of the number of characters in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A single character.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the memory manager for the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. For more information on <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and memory management for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, see [Memory Management with CStringT](../vs140/memory-management-with-cstringt.md).  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object to be copied into this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. For more information on <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, see the Remarks section.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A variant object to be copied into this <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The character type of the string class. Can be one of the following:  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (for ANSI character strings).  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (for Unicode character strings).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (for both ANSI and Unicode character strings).  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Boolean that specifies whether the project is an MFC DLL (TRUE) or not (FALSE).  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Must be <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and the project must be compiled with /clr.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A handle for a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Because the constructors copy the input data into new allocated storage, you should be aware that memory exceptions may result. Note that some of these constructors act as conversion functions. This allows you to substitute, for example, an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> where a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is expected.  
  
-   <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> ): Constructs a Unicode <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> from an ANSI string. You can also use this constructor to load a string resource as shown in the example below.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> ): Constructs a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> from a Unicode string.  
  
-   <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>( <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> ): Allows you to construct a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> from a pointer to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Define the **_CSTRING_DISABLE_NARROW_WIDE_CONVERSION** macro to turn off implicit string conversion between [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] and [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] strings. The macro excludes from compilation constructors that support conversion.  
  
 Note that the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter can be either a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object. For <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, use one of its default instantiations (<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>); for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, use a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> pointer. <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> declares an instance of the [CSimpleStringT Class](../vs140/csimplestringt-class.md), which is a smaller string class with less built-in functionality than the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> class.  
  
 The overload operator <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> constructs a <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> declaration.  
  
> [!NOTE]
>  Although it is possible to create <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> instances that contain embedded null characters, we recommend against it. Calling methods and operators on <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> objects that contain embedded null characters can produce unintended results.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#112](../vs140/codesnippet/CPP/cstringt--cstringt_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)   
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)