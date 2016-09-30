---
title: "CSid Class"
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
  - "CSid"
  - "ATL::CSid"
  - "ATL.CSid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSid class"
ms.assetid: be58b7ca-5958-49c3-a833-ca341aaaf753
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSid Class
This class is a wrapper for a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> (security identifier) structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CSid::CSidArray](../vs140/csid--csidarray.md)|An array of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> objects.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSid::CSid](../vs140/csid--csid.md)|The constructor.|  
|[CSid::~CSid](../vs140/csid--~csid.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSid::AccountName](../vs140/csid--accountname.md)|Returns the name of the account associated with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CSid::Domain](../vs140/csid--domain.md)|Returns the name of the domain associated with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.|  
|[CSid::EqualPrefix](../vs140/csid--equalprefix.md)|Tests <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> (security identifier) prefixes for equality.|  
|[CSid::GetLength](../vs140/csid--getlength.md)|Returns the length of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|[CSid::GetPSID](../vs140/csid--getpsid.md)|Returns a pointer to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure.|  
|[CSid::GetPSID_IDENTIFIER_AUTHORITY](../vs140/csid--getpsid_identifier_authority.md)|Returns a pointer to the **SID_IDENTIFIER_AUTHORITY** structure.|  
|[CSid::GetSubAuthority](../vs140/csid--getsubauthority.md)|Returns a specified subauthority in a **SID** structure.|  
|[CSid::GetSubAuthorityCount](../vs140/csid--getsubauthoritycount.md)|Returns the subauthority count.|  
|[CSid::IsValid](../vs140/csid--isvalid.md)|Tests the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object for validity.|  
|[CSid::LoadAccount](../vs140/csid--loadaccount.md)|Updates the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object given the account name and domain, or an existing <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> structure.|  
|[CSid::Sid](../vs140/csid--sid.md)|Returns the ID string.|  
|[CSid::SidNameUse](../vs140/csid--sidnameuse.md)|Returns a description of the state of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.|  
  
### Operators  
  
|||  
|-|-|  
|[operator =](../vs140/csid--operator-=.md)|Assignment operator.|  
|[operator const SID *](../vs140/csid--operator-const-sid--.md)|Casts a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object to a pointer to a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure.|  
  
### Global Operators  
  
|||  
|-|-|  
|[operator ==](../vs140/csid--operator-==.md)|Tests two security descriptor objects for equality|  
|[operator !=](../vs140/csid--operator-!=.md)|Tests two security descriptor objects for inequality|  
|[operator \<](../vs140/csid--operator--.md)|Compares relative value of two security descriptor objects.|  
|[operator >](../vs140/csid--operator--.md)|Compares relative value of two security descriptor objects.|  
|[operator \<=](../vs140/csid--operator--=.md)|Compares relative value of two security descriptor objects.|  
|[operator >=](../vs140/csid--operator--=.md)|Compares relative value of two security descriptor objects.|  
  
## Remarks  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> structure is a variable-length structure used to uniquely identify users or groups.  
  
 Applications should not modify the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> structure directly, but instead use the methods provided in this wrapper class. See also [AtlGetOwnerSid](../vs140/atlgetownersid.md), [AtlSetGroupSid](../vs140/atlsetgroupsid.md), [AtlGetGroupSid](../vs140/atlgetgroupsid.md), and [AtlSetOwnerSid](../vs140/atlsetownersid.md).  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="csid__accountname">\</a>  CSid::AccountName  
 Returns the name of the account associated with the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Returns the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> pointing to the name of the account.  
  
### Remarks  
 This method attempts to find a name for the specified <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> (security identifier). For full details, see [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166).  
  
 If no account name for the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> can be found, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns an empty string. This can occur if a network timeout prevents this method from finding the name. It also occurs for security identifiers with no corresponding account name, such as a logon <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that identifies a logon session.  
  
##  \<a name="csid__csid">\</a>  CSid::CSid  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> (security identifier) structure.  
  
 *IdentifierAuthority*  
 The authority.  
  
 *nSubAuthorityCount*  
 The subauthority count.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The account name.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The system name. This string can be the name of a remote computer. If this string is NULL, the local system is used instead.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 The constructor initializes the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object, setting an internal data member to *SidTypeInvalid*, or by copying the settings from an existing <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, or existing account.  
  
 If initialization fails, the constructor will throw a [CAtlException Class](../vs140/catlexception-class.md).  
  
##  \<a name="csid___dtorcsid">\</a>  CSid::~CSid  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees any resources acquired by the object.  
  
##  \<a name="csid__csidarray">\</a>  CSid::CSidArray  
 An array of [CSid](../vs140/csid-class.md) objects.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This typedef specifies the array type that can be used to retrieve security identifiers from an ACL (access-control list). See [CAcl::GetAclEntries](../vs140/cacl--getaclentries.md).  
  
##  \<a name="csid__domain">\</a>  CSid::Domain  
 Returns the name of the domain associated with the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> pointing to the domain.  
  
### Remarks  
 This method attempts to find a name for the specified <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> (security identifier). For full details, see [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166).  
  
 If no account name for the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> can be found,                         **Domain** returns the domain as an empty string. This can occur if a network timeout prevents this method from finding the name. It also occurs for security identifiers with no corresponding account name, such as a logon <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> that identifies a logon session.  
  
##  \<a name="csid__equalprefix">\</a>  CSid::EqualPrefix  
 Tests <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> (security identifier) prefixes for equality.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> (security identifier) structure or <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object to compare.  
  
### Return Value  
 Returns **true** on success,                         **false** on failure.  
  
### Remarks  
 See [EqualPrefixSid](http://msdn.microsoft.com/library/windows/desktop/aa446621) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more details.  
  
##  \<a name="csid__getlength">\</a>  CSid::GetLength  
 Returns the length of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns the length in bytes of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> structure is not valid, the return value is undefined. Before calling <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, use the [CSid::IsValid](../vs140/csid--isvalid.md) member function to verify that <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is valid.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object is not valid.  
  
##  \<a name="csid__getpsid">\</a>  CSid::GetPSID  
 Returns a pointer to a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> (security identifier) structure.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the address of the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object's underlying <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> structure.  
  
##  \<a name="csid__getpsid_identifier_authority">\</a>  CSid::GetPSID_IDENTIFIER_AUTHORITY  
 Returns a pointer to the **SID_IDENTIFIER_AUTHORITY** structure.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, it returns the address of the **SID_IDENTIFIER_AUTHORITY** structure. If it fails, the return value is undefined. Failure may occur if the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object is not valid, in which case the [CSid::IsValid](../vs140/csid--isvalid.md) method returns **false**. The function <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> can be called for extended error information.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object is not valid.  
  
##  \<a name="csid__getsubauthority">\</a>  CSid::GetSubAuthority  
 Returns a specified subauthority in a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> (security identifier) structure.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *nSubAuthority*  
 The subauthority.  
  
### Return Value  
 Returns the subauthority referenced by *nSubAuthority.* The subauthority value is a relative identifier (RID).  
  
### Remarks  
 The *nSubAuthority* parameter specifies an index value identifying the subauthority array element the method will return. The method performs no validation tests on this value. An application can call [CSid::GetSubAuthorityCount](../vs140/csid--getsubauthoritycount.md) to discover the range of acceptable values.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object is not valid.  
  
##  \<a name="csid__getsubauthoritycount">\</a>  CSid::GetSubAuthorityCount  
 Returns the subauthority count.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 If the method succeeds, the return value is the subauthority count.  
  
 If the method fails, the return value is undefined. The method fails if the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object is invalid. To get extended error information, call <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Under debug builds the function will cause an ASSERT if the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object is not valid.  
  
##  \<a name="csid__isvalid">\</a>  CSid::IsValid  
 Tests the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object for validity.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Returns **true** if the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object is valid,                         **false** if not. There is no extended error information for this method; do not call <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> method validates the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object by verifying that the revision number is within a known range and that the number of subauthorities is less than the maximum.  
  
##  \<a name="csid__loadaccount">\</a>  CSid::LoadAccount  
 Updates the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object given the account name and domain, or an existing SID (security identifier) structure.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The account name.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The system name. This string can be the name of a remote computer. If this string is NULL, the local system is used instead.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A pointer to a [SID](http://msdn.microsoft.com/library/windows/desktop/aa379594\(v=vs.85\).aspx) structure.  
  
### Return Value  
 Returns **true** on success,                         **false** on failure. To get extended error information, call <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> attempts to find a security identifier for the specified name. See [LookupAccountSid](http://msdn.microsoft.com/library/windows/desktop/aa379166\(v=vs.85\).aspx) for more details.  
  
##  \<a name="csid__operator__eq">\</a>  CSid::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> to assign to the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a reference to the updated <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> object.  
  
##  \<a name="csid__operator__eq_eq">\</a>  CSid::operator ==  
 Tests two security descriptor objects for equality.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> that appears on the left side of the == operator.  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> that appears on the right side of the == operator.  
  
### Return Value  
 **true** if the security descriptors are equal, otherwise **false**.  
  
##  \<a name="csid__operator__neq">\</a>  CSid::operator !=  
 Tests two security descriptor objects for inequality.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> that appears on the left side of the != operator.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> that appears on the right side of the != operator.  
  
### Return Value  
 **true** if the security descriptors are not equal, otherwise **false**.  
  
##  \<a name="csid__operator__lt_">\</a>  CSid::operator &lt;  
 Compares relative value of two security descriptor objects.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> that appears on the left side of the != operator.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> that appears on the right side of the != operator.  
  
### Return Value  
 **true** if <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, otherwise **false**.  
  
##  \<a name="csid__operator__lt__eq">\</a>  CSid::operator &lt;=  
 Compares relative value of two security descriptor objects.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> that appears on the left side of the != operator.  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> that appears on the right side of the != operator.  
  
### Return Value  
 **true** if <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is less than or equal to <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, otherwise **false**.  
  
##  \<a name="csid__operator__gt_">\</a>  CSid::operator &gt;  
 Compares relative value of two security descriptor objects.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> that appears on the left side of the != operator.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> that appears on the right side of the != operator.  
  
### Return Value  
 **true** if <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>, otherwise **false**.  
  
##  \<a name="csid__operator__gt__eq">\</a>  CSid::operator &gt;=  
 Compares relative value of two security descriptor objects.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> that appears on the left side of the != operator.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> (security identifier) or <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> that appears on the right side of the != operator.  
  
### Return Value  
 **true** if <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is greater than or equal to <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>, otherwise **false**.  
  
##  \<a name="csid__operator_const_sid__star">\</a>  CSid::operator const SID *  
 Casts a <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object to a pointer to a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> (security identifier) structure.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Remarks  
 Returns the address of the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> structure.  
  
##  \<a name="csid__sid">\</a>  CSid::Sid  
 Returns the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> (security identifier) structure as a string.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 Returns the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> structure as a string in a format suitable for display, storage, or transmission. Equivalent to [ConvertSidToStringSid](http://msdn.microsoft.com/library/windows/desktop/aa376399), although this function is only available on Windows 2000 or later and so is emulated for earlier operating systems.  
  
##  \<a name="csid__sidnameuse">\</a>  CSid::SidNameUse  
 Returns a description of the state of the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 Returns the value of the data member that stores a value describing the state of the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object.  
  
|Value|Description|  
|-----------|-----------------|  
|SidTypeUser|Indicates a user <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> (security identifier).|  
|SidTypeGroup|Indicates a group <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>.|  
|SidTypeDomain|Indicates a domain <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.|  
|SidTypeAlias|Indicates an alias <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.|  
|SidTypeWellKnownGroup|Indicates a <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> for a well-known group.|  
|SidTypeDeletedAccount|Indicates a <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> for a deleted account.|  
|SidTypeInvalid|Indicates an invalid <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.|  
|SidTypeUnknown|Indicates an unknown <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> type.|  
|SidTypeComputer|Indicates a <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> for a computer.|  
  
### Remarks  
 Call [CSid::LoadAccount](../vs140/csid--loadaccount.md) to update the <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object before calling <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> to return its state. <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> does not change the state of the object (by calling to **LookupAccountName** or **LookupAccountSid**), but only returns the current state.  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)   
 [Operators Alphabetical Reference](../vs140/atl-operators-alphabetical-reference.md)