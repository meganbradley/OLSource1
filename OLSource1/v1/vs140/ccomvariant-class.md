---
title: "CComVariant Class"
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
  - "ATL.CComVariant"
  - "ATL::CComVariant"
  - "CComVariant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VARIANT macro"
  - "CComVariant class"
  - "VARIANT macro, ATL"
ms.assetid: 4d31149c-d005-44b5-a509-10f84afa2b61
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant Class
This class wraps the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type, providing a member indicating the type of data stored.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComVariant::CComVariant](../vs140/ccomvariant--ccomvariant.md)|The constructor.|  
|[CComVariant::~CComVariant](../vs140/ccomvariant--~ccomvariant.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComVariant::Attach](../vs140/ccomvariant--attach.md)|Attaches a **VARIANT** to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
|[CComVariant::ChangeType](../vs140/ccomvariant--changetype.md)|Converts the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to a new type.|  
|[CComVariant::Clear](../vs140/ccomvariant--clear.md)|Clears the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.|  
|[CComVariant::Copy](../vs140/ccomvariant--copy.md)|Copies a **VARIANT** to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[CComVariant::CopyTo](../vs140/ccomvariant--copyto.md)|Copies the contents of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[CComVariant::Detach](../vs140/ccomvariant--detach.md)|Detaches the underlying **VARIANT** from the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
|[CComVariant::GetSize](../vs140/ccomvariant--getsize.md)|Returns the size in number of bytes of the contents of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.|  
|[CComVariant::ReadFromStream](../vs140/ccomvariant--readfromstream.md)|Loads a **VARIANT** from a stream.|  
|[CComVariant::SetByRef](../vs140/ccomvariant--setbyref.md)|Initializes the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object and sets the **vt** member to **VT_BYREF**.|  
|[CComVariant::WriteToStream](../vs140/ccomvariant--writetostream.md)|Saves the underlying **VARIANT** to a stream.|  
  
### Public Operators  
  
|||  
|-|-|  
|[CComVariant::operator <](../vs140/ccomvariant--operator--.md)|Indicates whether the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is less than the specified **VARIANT**.|  
|[CComVariant::operator >](../vs140/ccomvariant--operator--.md)|Indicates whether the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is greater than the specified **VARIANT**.|  
|[operator !=](../vs140/ccomvariant--operator-!=.md)|Indicates whether the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object does not equal the specified **VARIANT**.|  
|[operator =](../vs140/ccomvariant--operator-=.md)|Assigns a value to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.|  
|[operator ==](../vs140/ccomvariant--operator-==.md)|Indicates whether the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object equals the specified **VARIANT**.|  
  
## Remarks  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> wraps the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> type, which consists of a union and a member indicating the type of the data stored in the union. **VARIANT**s are typically used in Automation.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> derives from the **VARIANT** type so it can be used wherever a **VARIANT** can be used. You can, for example, use the **V_VT** macro to extract the type of a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> or you can access the **vt** member directly just as you can with a **VARIANT**.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcomcli.h  
  
##  \<a name="ccomvariant__attach">\</a>  CComVariant::Attach  
 Safely clears the current contents of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object, copies the contents of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> into this object, then sets the variant type of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 [in] Points to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be attached to the object.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Ownership of the data held by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is transferred to the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
##  \<a name="ccomvariant__ccomvariant">\</a>  CComVariant::CComVariant  
 Each constructor handles the safe initialization of the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> Win32 function or by setting the object's value and type according to the parameters passed.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *varSrc*  
 [in] The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object. The contents of the source variant are copied to the destination without conversion.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 [in] The character string used to initialize the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the constructor or an ANSI string to the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> version. In either case the string is converted to a Unicode <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> allocated using **SysAllocString**. The type of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> argument is converted to a **VARIANT_BOOL** before being stored. The type of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>,                                 **BYTE**,                                 **short**,                                 **long**,                                 **LONGLONG**,                                 **ULONGLONG**,                                 **unsigned short**, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>,                                 **VT_I8**,                                 **VT_UI8**,                                 **VT_UI2**,                                 **VT_UI4**, or **VT_UI4**, respectively.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 [in] The type of the variant. When the first parameter is <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, valid types are <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> and **VT_INT**. When the first parameter is **long**, valid types are <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>. When the first parameter is **double**, valid types are <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>. When the first parameter is <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, valid types are **VT_UI4** and **VT_UINT**.  
  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 [in] The **float** used to initialize the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 [in] The **double** used to initialize the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 [in] The **CY** used to initialize the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> or **IUnknown** pointer used to initialize the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> will be called on the interface pointer. The type of the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, the **SAFERRAY** pointer used to initialize the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object. A copy of the **SAFEARRAY** is stored in the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> used to initialize the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object will be **VT_I1**.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 [in] The BSTR used to initialize the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
### Remarks  
 The destructor manages cleanup by calling [CComVariant::Clear](../vs140/ccomvariant--clear.md).  
  
##  \<a name="ccomvariant___dtorccomvariant">\</a>  CComVariant::~CComVariant  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This method manages cleanup by calling [CComVariant::Clear](../vs140/ccomvariant--clear.md).  
  
##  \<a name="ccomvariant__changetype">\</a>  CComVariant::ChangeType  
 Converts the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object to a new type.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 [in] The new type for the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 [in] A pointer to the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> whose value will be converted to the new type. The default value is **NULL**, meaning the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object will be converted in place.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> value.  
  
### Remarks  
 If you pass a value for <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> will use this **VARIANT** as the source for the conversion. Otherwise, the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object will be the source.  
  
##  \<a name="ccomvariant__clear">\</a>  CComVariant::Clear  
 Clears the <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object by calling the <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> Win32 function.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A standard <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The destructor automatically calls **Clear**.  
  
##  \<a name="ccomvariant__copy">\</a>  CComVariant::Copy  
 Frees the <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object and then assigns it a copy of the specified **VARIANT**.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
 [in] A pointer to the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be copied.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> value.  
  
##  \<a name="ccomvariant__copyto">\</a>  CComVariant::CopyTo  
 Copies the contents of the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pstrDest*  
 Points to a <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> that will receive a copy of the contents of the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The **CComVariant** object must be of type <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomvariant__detach">\</a>  CComVariant::Detach  
 Detaches the underlying **VARIANT** from the <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> object and sets the object's type to <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 [out] Returns the underlying <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> value of the object.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Note that the contents of the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> referenced by <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> will automatically be cleared before being assigned the value and type of the calling **CComVariant** object.  
  
##  \<a name="ccomvariant__getsize">\</a>  CComVariant::GetSize  
 For simple-fixed size <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>s, this method returns the <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> the underlying data type plus <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The size in bytes of the current contents of the <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> contains an interface pointer, <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> queries for <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. If successful, the return value is the low-order 32 bits of the value returned by <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> plus the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>. If the interface pointer is <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> returns the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> plus <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>. If the total size is larger than <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> which indicates an error.  
  
 In all other cases, a temporary <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> is coerced from the current <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>. The length of this <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is calculated as the size of the length of the string plus the length of the string itself plus the size of the null character plus <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> cannot be coerced to a <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
 The size returned by this method matches the number of bytes used by [CComVariant::WriteToStream](../vs140/ccomvariant--writetostream.md) under successful conditions.  
  
##  \<a name="ccomvariant__operator__eq">\</a>  CComVariant::operator =  
 Assigns a value and corresponding type to the <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *varSrc*  
 [in] The <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> or [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) to be assigned to the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object. The contents of the source variant are copied to the destination without conversion.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 [in] The BSTR to be assigned to the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 [in] The character string to be assigned to the <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> object. You can pass a zero-terminated wide (Unicode) character string to the **LPCOLESTR** version of the operator or an ANSI string to the <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> version. In either case, the string is converted to a Unicode <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> allocated using **SysAllocString**. The type of the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> to be assigned to the <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> argument is converted to a **VARIANT_BOOL** before being stored. The type of the <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>,                                 **BYTE**,                                 **short**,                                 **long**,                                 **LONGLONG**,                                 **ULONGLONG**,                                 **unsigned short**, <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> to be assigned to the <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>,                                 **VT_I8**,                                 **VT_UI8**,                                 **VT_UI2**,                                 **VT_UI4**, or **VT_UI4**, respectively.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 [in] The **float** to be assigned to the <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 [in] The **double** to be assigned to the <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 [in] The **CY** to be assigned to the <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> object will be <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 [in] The <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> or **IUnknown** pointer to be assigned to the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> will be called on the interface pointer. The type of the <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> object will be **VT_DISPATCH** or **VT_UNKNOWN**, respectively.  
  
 Or, a **SAFEARRAY** pointer to be assigned to the <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> object. A copy of the **SAFEARRAY** is stored in the <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> object will be a combination of the original type of the **SAFEARRAY** and **VT_ARRAY**.  
  
 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 [in] The char to be assigned to the <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> object. The type of the <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> object will be **VT_I1**.  
  
##  \<a name="ccomvariant__operator__eq_eq">\</a>  CComVariant::operator ==  
 Indicates whether the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> object equals the specified **VARIANT**.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Returns **true** if the value and type of *varSrc* are equal to the value and type, respectively, of the <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> object. Otherwise,                         **false**. The operator uses the user's default locale to perform the comparison.  
  
 The operator compares only the value of the variant types. It compares strings, integers, and floating points, but not arrays or records.  
  
##  \<a name="ccomvariant__operator__neq">\</a>  CComVariant::operator !=  
 Indicates whether the <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> object does not equal the specified **VARIANT**.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 Returns **true** if either the value or type of *varSrc* is not equal to the value or type, respectively, of the <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> object. Otherwise,                         **false**. The operator uses the user's default locale to perform the comparison.  
  
 The operator compares only the value of the variant types. It compares strings, integers, and floating points, but not arrays or records.  
  
##  \<a name="ccomvariant__operator__lt_">\</a>  CComVariant::operator &lt;  
 Indicates whether the <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> object is less than the specified **VARIANT**.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 Returns **true** if the value of the <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> object is less than the value of *varSrc*. Otherwise,                         **false**. The operator uses the user's default locale to perform the comparison.  
  
##  \<a name="ccomvariant__operator__gt_">\</a>  CComVariant::operator &gt;  
 Indicates whether the <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> object is greater than the specified **VARIANT**.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 Returns **true** if the value of the <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> object is greater than the value of *varSrc*. Otherwise,                         **false**. The operator uses the user's default locale to perform the comparison.  
  
##  \<a name="ccomvariant__readfromstream">\</a>  CComVariant::ReadFromStream  
 Sets the underlying **VARIANT** to the **VARIANT** contained in the specified stream.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on the stream containing the data.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> value.  
  
### Remarks  
 **ReadToStream** requires a previous call to [WriteToStream](../vs140/ccomvariant--writetostream.md).  
  
##  \<a name="ccomvariant__setbyref">\</a>  CComVariant::SetByRef  
 Initializes the <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> object and sets the **vt** member to **VT_BYREF**.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 The type of **VARIANT**, for example, <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>.  
  
 *pT*  
 The pointer used to initialize the <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> object.  
  
### Remarks  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> is a function template that initializes the <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> object to the pointer *pT* and sets the **vt** member to **VT_BYREF**. For example:  
  
 [!code[NVC_ATL_Utilities#76](../vs140/codesnippet/CPP/ccomvariant-class_1.cpp)]  
  
##  \<a name="ccomvariant__writetostream">\</a>  CComVariant::WriteToStream  
 Saves the underlying **VARIANT** to a stream.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 [in] A pointer to the [IStream](http://msdn.microsoft.com/library/windows/desktop/aa380034) interface on a stream.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> value.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)