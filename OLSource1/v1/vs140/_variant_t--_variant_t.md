---
title: "_variant_t::_variant_t"
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
  - "_variant_t::_variant_t"
  - "_variant_t._variant_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_variant_t class, constructor"
  - "_variant_t method"
ms.assetid: a50e5b33-d4c6-4a26-8e7e-a0a25fd9895b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t::_variant_t
**Microsoft Specific**  
  
 Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *varSrc*  
 A **VARIANT** object to be copied into the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 *pVarSrc*  
 Pointer to a **VARIANT** object to be copied into the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 *var_t_Src*  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If false, the supplied **VARIANT** object is attached to the new <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object without making a new copy by **VariantCopy**.  
  
 *ISrc, sSrc*  
 An integer value to be copied into the new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The **VARTYPE** for the new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 *fltSrc, dblSrc*  
 A numerical value to be copied into the new <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A **CY** object to be copied into the new <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 *strSrc, wstrSrc*  
 A string to be copied into the new <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value to be copied into the new <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 COM interface pointer to a **VT_UNKNOWN** object to be encapsulated into the new <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 COM interface pointer to a **VT_DISPATCH** object to be encapsulated into the new <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A **DECIMAL** value to be copied into the new <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A **BYTE** value to be copied into the new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> value to be copied into the new <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
 *usSrc*  
 A **unsigned short** value to be copied into the new <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
 *ulSrc*  
 A <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value to be copied into the new <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> value to be copied into the new <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
 *uiSrc*  
 An <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> value to be copied into the new <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
 *i8Src*  
 An __**int64** value to be copied into the new <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
 *ui8Src*  
 An **unsigned __int64** value to be copied into the new <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
## Remarks  
  
-   **_variant_t( )** Constructs an empty <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
-   **_variant_t( VARIANT&**  *varSrc*  **)** Constructs a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object from a copy of the **VARIANT** object. The variant type is retained.  
  
-   **_variant_t( VARIANT\***  *pVarSrc*  **)** Constructs a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object from a copy of the **VARIANT** object. The variant type is retained.  
  
-   **_variant_t( _variant_t&**  *var_t_Src*  **)** Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object from another <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. The variant type is retained.  
  
-   **_variant_t( VARIANT&**  *varSrc* **, bool**  <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object from an existing **VARIANT** object. If <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is **false**, the **VARIANT** object is attached to the new object without making a copy.  
  
-   **_variant_t( short**  *sSrc* **, VARTYPE**  <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  **= VT_I2 )** Constructs a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> from a **short** integer value. Any other **VARTYPE** results in an <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> error.  
  
-   **_variant_t( long**  <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> **, VARTYPE**  <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  **= VT_I4 )** Constructs a <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> from a **long** integer value. Any other **VARTYPE** results in an <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> error.  
  
-   **_variant_t( float**  <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> from a **float** numerical value.  
  
-   **_variant_t( double**  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> **, VARTYPE**  <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  **= VT_R8 )** Constructs a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> from a **double** numerical value. Any other **VARTYPE** results in an <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> error.  
  
-   **_variant_t( CY&**  <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> from a **CY** object.  
  
-   **_variant_t( _bstr_t&**  <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> from a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object. A new <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is allocated.  
  
-   **_variant_t( wchar_t \*** *wstrSrc*  **)** Constructs a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> from a Unicode string. A new <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is allocated.  
  
-   **_variant_t( char\***  <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> from a string. A new <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is allocated.  
  
-   **_variant_t( bool**  <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> from a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> value.  
  
-   **_variant_t( IUnknown\***  <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> **, bool**  <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  **= true )** Constructs a <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object of type **VT_UNKNOWN** from a COM interface pointer. If <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is **true**, then <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is called on the supplied interface pointer to match the call to **Release** that will occur when the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object is destroyed. It is up to you to call **Release** on the supplied interface pointer. If <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is **false**, this constructor takes ownership of the supplied interface pointer; do not call **Release** on the supplied interface pointer.  
  
-   **_variant_t( IDispatch\***  <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> **, bool**  <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  **= true )** Constructs a <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object of type **VT_DISPATCH** from a COM interface pointer. If <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> is **true**, then <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is called on the supplied interface pointer to match the call to **Release** that will occur when the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object is destroyed. It is up to you to call **Release** on the supplied interface pointer. If **fAddRef** is false, this constructor takes ownership of the supplied interface pointer; do not call **Release** on the supplied interface pointer.  
  
-   **_variant_t( DECIMAL&**  <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object of type **VT_DECIMAL** from a **DECIMAL** value.  
  
-   **_variant_t( BYTE**  <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  **)** Constructs a <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> from a **BYTE** value.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../vs140/_variant_t-class.md)