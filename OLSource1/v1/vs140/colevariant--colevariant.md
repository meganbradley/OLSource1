---
title: "COleVariant::COleVariant"
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
  - "VT_CY"
  - "VT_R8"
  - "VT_R4"
  - "COleVariant::COleVariant"
  - "COleVariant.COleVariant"
  - "VT_I2"
  - "VT_ERROR"
  - "VT_BSTRT"
  - "VT_BOOL"
  - "VT_DATE"
  - "VT_EMPTY"
  - "VT_UI1"
  - "VT_BSTR"
  - "VT_I4"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VT_BOOL"
  - "VT_R8"
  - "VT_BSTR"
  - "VT_DATE"
  - "VT_BSTRT"
  - "VT_I4"
  - "VT_ERROR"
  - "VT_EMPTY"
  - "COleVariant class, constructor"
  - "VT_CY"
  - "VT_I2"
  - "VT_R4"
  - "VT_UI1"
ms.assetid: 4aacf985-71fa-475f-91f0-7cf44d4cbe63
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::COleVariant
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *varSrc*  
 An existing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or **VARIANT** object to be copied into the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a **VARIANT** object that will be copied into the new <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into the new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for the new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object to be copied into the new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A numerical value to be copied into the new <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> for the new <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A [COleCurrency](../vs140/colecurrency-class.md) object to be copied into the new <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A numerical value to be copied into the new <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A [COleDateTime](../vs140/coledatetime-class.md) object to be copied into the new <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A [CByteArray](../vs140/cbytearray-class.md) object to be copied into the new <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A [CLongBinary](../vs140/clongbinary-class.md) object to be copied into the new <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to a [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) structure to be copied into the new <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
## Remarks  
 All these constructors create new <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> objects initialized to the specified value. A brief description of each of these constructors follows.  
  
-   **COleVariant( )** Creates an empty <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  *varSrc*  **)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object. The variant type is retained.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  **)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object. The variant type is retained.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  **)** Copies a string into the new object, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> (UNICODE).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  **)** Copies a string into the new object. The parameter <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> (UNICODE) or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> (ANSI).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  **)** Copies a string into the new object, **VT_BSTR** (UNICODE).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  **)** Copies an 8-bit integer into the new object, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  **)** Copies a 16-bit integer (or Boolean value) into the new object. The parameter <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  **)** Copies a 32-bit integer (or <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value) into the new object. The parameter <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  **)** Copies a **COleCurrency** value into the new object, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  **)** Copies a 32-bit floating-point value into the new object, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  **)** Copies a 64-bit floating-point value into the new object, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> value into the new object, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object into the new object, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object into the new object, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::operator =](../vs140/colevariant--operator-=.md)   
 [CStringT Class](../vs140/cstringt-class.md)   
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [COleDateTime Class](../vs140/coledatetime-class.md)