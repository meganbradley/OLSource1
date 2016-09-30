---
title: "COleVariant Class"
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
  - "COleVariant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Automation, parameter types"
  - "COleVariant class"
  - "VARIANT data type"
ms.assetid: e1b5cd4a-b066-4b9b-b48b-6215ed52d998
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant Class
Encapsulates the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleVariant::COleVariant](#colevariant__colevariant)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleVariant::Attach](#colevariant__attach)|Attaches a **VARIANT** to a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|[COleVariant::ChangeType](#colevariant__changetype)|Changes the variant type of this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[COleVariant::Clear](#colevariant__clear)|Clears this <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[COleVariant::Detach](#colevariant__detach)|Detaches a **VARIANT** from a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and returns the **VARIANT**.|  
|[COleVariant::GetByteArrayFromVariantArray](#colevariant__getbytearrayfromvariantarray)|Retrieves a byte array from an existing variant array.|  
|[COleVariant::SetString](#colevariant__setstring)|Sets the string to a particular type, typically ANSI.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[COleVariant::operator LPCVARIANT](#colevariant__operator_lpcvariant)|Converts a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value into an <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[COleVariant::operator LPVARIANT](#colevariant__operator_lpvariant)|Converts a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object into an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[COleVariant::operator =](#colevariant__operator__eq)|Copies a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value.|  
|[COleVariant::operator ==](#colevariant__operator__eq_eq)|Compares two <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> values.|  
|[COleVariant::operator <\<, >>](#colevariant__operator__lt__lt___gt__gt_)|Outputs a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and inputs a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
## Remarks  
 This data type is used in OLE automation. Specifically, the [DISPPARAMS](assetId:///a16e5a21-766e-4287-b039-13429aa78f8b) structure contains a pointer to an array of **VARIANT** structures. A **DISPPARAMS** structure is used to pass parameters to [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d).  
  
> [!NOTE]
>  This class is derived from the **VARIANT** structure. This means you can pass a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in a parameter that calls for a **VARIANT** and that the data members of the **VARIANT** structure are accessible data members of <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The two related MFC classes [COleCurrency](../vs140/colecurrency-class.md) and [COleDateTime](../vs140/coledatetime-class.md) encapsulate the variant data types **CURRENCY** ( <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>) and **DATE** ( <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>). The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class is used extensively in the DAO classes; see these classes for typical usage of this class, for example [CDaoQueryDef](../vs140/cdaoquerydef-class.md) and [CDaoRecordset](../vs140/cdaorecordset-class.md).  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [CURRENCY](assetId:///5e81273c-7289-45c7-93c0-32c1553f708e), [DISPPARAMS](assetId:///a16e5a21-766e-4287-b039-13429aa78f8b), and [IDispatch::Invoke](assetId:///964ade8e-9d8a-4d32-bd47-aa678912a54d) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information on the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class and its use in OLE automation, see "Passing Parameters in OLE Automation" in the article [Automation](../vs140/automation.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdisp.h  
  
##  \<a name="colevariant__attach">\</a>  COleVariant::Attach  
 Call this function to attach the given [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object to the current <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *varSrc*  
 An existing **VARIANT** object to be attached to the current <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This function sets the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) of                         *varSrc* to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) and [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__colevariant">\</a>  COleVariant::COleVariant  
 Constructs a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *varSrc*  
 An existing <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> or **VARIANT** object to be copied into the new <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A pointer to a **VARIANT** object that will be copied into the new <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into the new <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> for the new <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object to be copied into the new <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A numerical value to be copied into the new <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> for the new <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A [COleCurrency](../vs140/colecurrency-class.md) object to be copied into the new <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A numerical value to be copied into the new <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A [COleDateTime](../vs140/coledatetime-class.md) object to be copied into the new <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A [CByteArray](../vs140/cbytearray-class.md) object to be copied into the new <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A [CLongBinary](../vs140/clongbinary-class.md) object to be copied into the new <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A pointer to a                                 [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) structure to be copied into the new <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.  
  
### Remarks  
 All these constructors create new <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> objects initialized to the specified value. A brief description of each of these constructors follows.  
  
-   **COleVariant( )** Creates an empty <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  *varSrc*  **)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object. The variant type is retained.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  **)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object. The variant type is retained.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  **)** Copies a string into the new object, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> (UNICODE).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  **)** Copies a string into the new object. The parameter <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> (UNICODE) or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> (ANSI).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  **)** Copies a string into the new object, **VT_BSTR** (UNICODE).  
  
-   **COleVariant(**  <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  **)** Copies an 8-bit integer into the new object, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  **)** Copies a 16-bit integer (or Boolean value) into the new object. The parameter <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  **)** Copies a 32-bit integer (or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> value) into the new object. The parameter <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  **)** Copies a **COleCurrency** value into the new object, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  **)** Copies a 32-bit floating-point value into the new object, <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  **)** Copies a 64-bit floating-point value into the new object, <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> value into the new object, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object into the new object, <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>.  
  
-   **COleVariant(**  <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  **)** Copies a <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> object into the new object, <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, see                         [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__changetype">\</a>  COleVariant::ChangeType  
 Converts the type of variant value in this <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 The [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) for this <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 A pointer to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object to be converted. If this value is **NULL**, this <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object is used as the source for the conversion.  
  
### Remarks  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4), and [VariantChangeType](assetId:///48a51e32-95d7-4eeb-8106-f5043ffa2fd1) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__clear">\</a>  COleVariant::Clear  
 Clears the **VARIANT**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This sets the **VARTYPE** for this object to <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> destructor calls this function.  
  
 For more information, see the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__detach">\</a>  COleVariant::Detach  
 Detaches the underlying [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) object from this <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This function sets the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) for this <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  After calling **Detach**, it is the caller's responsibility to call **VariantClear** on the resulting **VARIANT** structure.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118), [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4), and [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__getbytearrayfromvariantarray">\</a>  COleVariant::GetByteArrayFromVariantArray  
 Retrieves a byte array from an existing variant array  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 A reference to an existing [CByteArray](../vs140/cbytearray-class.md) object.  
  
##  \<a name="colevariant__operator_lpcvariant">\</a>  COleVariant::operator LPCVARIANT  
 This casting operator returns a <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> structure whose value is copied from this <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="colevariant__operator_lpvariant">\</a>  COleVariant::operator LPVARIANT  
 Call this casting operator to access the underlying <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> structure for this <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
> [!CAUTION]
>  Changing the value in the **VARIANT** structure accessed by the pointer returned by this function will change the value of this <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object.  
  
##  \<a name="colevariant__operator__eq">\</a>  COleVariant::operator =  
 These overloaded assignment operators copy the source value into this <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 A brief description of each operator follows:  
  
-   **operator =(** *varSrc***)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object into this object.  
  
-   **operator =(** <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> **)** Copies the **VARIANT** object accessed by <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> into this object.  
  
-   **operator =(** <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> **)** Copies a null-terminated string into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> **)** Copies a [CString](../vs140/cstringt-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> **)** Copies an 8- or 16-bit integer value into this object. If <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> is an 8-bit value, the **VARTYPE** of this is set to <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is a 16-bit value and the **VARTYPE** of this is <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>, it is kept; otherwise, it is set to <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> **)** Copies a 32-bit integer value into this object. If the **VARTYPE** of this is <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, it is kept; otherwise, it is set to <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> **)** Copies a [COleCurrency](../vs140/colecurrency-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> **)** Copies a 32-bit floating-point value into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> **)** Copies a 64-bit floating-point value into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> **)** Copies a [COleDateTime](../vs140/coledatetime-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> **)** Copies a [CByteArray](../vs140/cbytearray-class.md) object into this <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> object.  
  
-   **operator =(** <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> **)** Copies a [CLongBinary](../vs140/clongbinary-class.md) object into this <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> object.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) and [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colevariant__operator__eq_eq">\</a>  COleVariant::operator ==  
 This operator compares two variant values and returns nonzero if they are equal; otherwise 0.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="colevariant__operator__lt__lt___gt__gt_">\</a>  COleVariant::operator &lt;&lt;, &gt;&gt;  
 Outputs a <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> value to <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> or **CdumpContext** and inputs a <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> insertion ( **<\<**) operator supports diagnostic dumping and storing to an archive. The extraction ( **>>**) operator supports loading from an archive.  
  
##  \<a name="colevariant__setstring">\</a>  COleVariant::SetString  
 Sets the string to a particular type.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into the new <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object.  
  
 *VtSrc*  
 The **VARTYPE** for the new <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The parameter <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> (UNICODE) or <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> (ANSI). <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> is typically used to set strings to ANSI, since the default for the [COleVariant::COleVariant](#colevariant__colevariant) constructor with a string or string pointer parameter and no **VARTYPE** is UNICODE.  
  
 A DAO recordset in a non-UNICODE build expects strings to be ANSI. Thus, for DAO functions that use <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> objects, if you are not creating a UNICODE recordset, you must use the **COleVariant::COleVariant(** <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> (ANSI) or use <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> to make ANSI strings. For example, the <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> functions [CDaoRecordset::Seek](../vs140/cdaorecordset-class.md#cdaorecordset__seek) and [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset-class.md#cdaorecordset__setfieldvalue) use <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> objects as parameters. These objects must be ANSI if the DAO recordset is not UNICODE.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)