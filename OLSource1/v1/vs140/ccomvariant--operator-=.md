---
title: "CComVariant::operator ="
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
  - "CComVariant.operator="
  - "ATL.CComVariant.operator="
  - "CComVariant::operator="
  - "ATL::CComVariant::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, variant"
  - "operator =, variant"
ms.assetid: c0ae51a7-5e2a-48f2-bdd7-20e94f5bc31d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::operator =
Assigns a value and corresponding type to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *varSrc*  
 [in] The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be assigned to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The contents of the source variant are copied to the destination without conversion.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The BSTR to be assigned to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The character string to be assigned to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the operator or an ANSI string to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> version. In either case, the string is converted to a Unicode <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> allocated using **SysAllocString**. The type of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to be assigned to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument is converted to a **VARIANT_BOOL** before being stored. The type of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, **BYTE**, **short**, **long**, **LONGLONG**, **ULONGLONG**, **unsigned short**, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to be assigned to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, **VT_I8**, **VT_UI8**, **VT_UI2**, **VT_UI4**, or **VT_UI4**, respectively.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 [in] The **float** to be assigned to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [in] The **double** to be assigned to the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 [in] The **CY** to be assigned to the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or **IUnknown** pointer to be assigned to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> will be called on the interface pointer. The type of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, a **SAFEARRAY** pointer to be assigned to the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. A copy of the **SAFEARRAY** is stored in the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 [in] The char to be assigned to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object will be **VT_I1**.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::Copy](../vs140/ccomvariant--copy.md)   
 [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118)