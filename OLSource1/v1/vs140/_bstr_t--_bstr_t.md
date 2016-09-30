---
title: "_bstr_t::_bstr_t"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_bstr_t::_bstr_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BSTR object"
  - "_bstr_t method"
  - "_bstr_t class"
ms.assetid: 116d994e-5a72-4351-afbe-866c80b4c165
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::_bstr_t
**Microsoft Specific**  
  
 Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to be copied.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A multibyte string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Unicode string  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A [_variant_t](../vs140/_variant_t-class.md) object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> argument is attached to the new object without making a copy by calling <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The following table describes the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> constructors.  
  
|Constructor|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Constructs a default <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object that encapsulates a null <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object as a copy of another.\<br />\<br /> This is a *shallow* copy, which increments the reference count of the encapsulated <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object instead of creating a new one.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object by calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to create a new <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object and then encapsulates it.\<br />\<br /> This constructor first performs a multibyte to Unicode conversion.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object by calling <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to create a new <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object and then encapsulates it.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object by first retrieving a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object from the encapsulated VARIANT object.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object from an existing <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> (as opposed to a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> string). If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is false, the supplied <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is attached to the new object without making a new copy with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.\<br />\<br /> This constructor is used by wrapper functions in the type library headers to encapsulate and take ownership of a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> that is returned by an interface method.|  
  
 **END Microsoft Specific**  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)   
 [_variant_t Class](../vs140/_variant_t-class.md)