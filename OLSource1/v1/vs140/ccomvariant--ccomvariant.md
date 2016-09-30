---
title: "CComVariant::CComVariant"
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
  - "ATL.CComVariant.CComVariant"
  - "CComVariant::CComVariant"
  - "ATL::CComVariant::CComVariant"
  - "CComVariant.CComVariant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComVariant class, constructor"
  - "CComVariant constructor"
ms.assetid: 273b3b8f-f9f4-4d15-8d95-002df57e3b62
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::CComVariant
Each constructor handles the safe initialization of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Win32 function or by setting the object's value and type according to the parameters passed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *varSrc*  
 [in] The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. The contents of the source variant are copied to the destination without conversion.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The character string used to initialize the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the constructor or an ANSI string to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> version. In either case the string is converted to a Unicode <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> allocated using **SysAllocString**. The type of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument is converted to a **VARIANT_BOOL** before being stored. The type of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, **BYTE**, **short**, **long**, **LONGLONG**, **ULONGLONG**, **unsigned short**, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, **VT_I8**, **VT_UI8**, **VT_UI2**, **VT_UI4**, or **VT_UI4**, respectively.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 [in] The type of the variant. When the first parameter is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, valid types are <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and **VT_INT**. When the first parameter is **long**, valid types are <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>. When the first parameter is **double**, valid types are <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. When the first parameter is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, valid types are **VT_UI4** and **VT_UINT**.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 [in] The **float** used to initialize the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 [in] The **double** used to initialize the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 [in] The **CY** used to initialize the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or **IUnknown** pointer used to initialize the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> will be called on the interface pointer. The type of the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, the **SAFERRAY** pointer used to initialize the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object. A copy of the **SAFEARRAY** is stored in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object will be **VT_I1**.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 [in] The BSTR used to initialize the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
## Remarks  
 The destructor manages cleanup by calling [CComVariant::Clear](../vs140/ccomvariant--clear.md).  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)