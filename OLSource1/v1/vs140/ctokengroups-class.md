---
title: "CTokenGroups Class"
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
  - "ATL::CTokenGroups"
  - "ATL.CTokenGroups"
  - "CTokenGroups"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTokenGroups class"
ms.assetid: 2ab08076-4b08-4487-bc70-ec6dee304190
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTokenGroups Class
This class is a wrapper for the **TOKEN_GROUPS** structure.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenGroups::CTokenGroups](../vs140/ctokengroups--ctokengroups.md)|The constructor.|  
|[CTokenGroups::~CTokenGroups](../vs140/ctokengroups--~ctokengroups.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenGroups::Add](../vs140/ctokengroups--add.md)|Adds a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or existing **TOKEN_GROUPS** structure to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[CTokenGroups::Delete](../vs140/ctokengroups--delete.md)|Deletes a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and its associated attributes from the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[CTokenGroups::DeleteAll](../vs140/ctokengroups--deleteall.md)|Deletes all <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects and their associated attributes from the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CTokenGroups::GetCount](../vs140/ctokengroups--getcount.md)|Returns the number of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects and associated attributes contained in the **CTokenGroups** object.|  
|[CTokenGroups::GetLength](../vs140/ctokengroups--getlength.md)|Returns the size of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CTokenGroups::GetPTOKEN_GROUPS](../vs140/ctokengroups--getptoken_groups.md)|Retrieves a pointer to the **TOKEN_GROUPS** structure.|  
|[CTokenGroups::GetSidsAndAttributes](../vs140/ctokengroups--getsidsandattributes.md)|Retrieves the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> objects and attributes belonging to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
|[CTokenGroups::LookupSid](../vs140/ctokengroups--lookupsid.md)|Retrieves the attributes associated with a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CTokenGroups::operator const TOKEN_GROUPS*](../vs140/ctokengroups--operator-const-token_groups--.md)|Casts the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object to a pointer to the **TOKEN_GROUPS** structure.|  
|[CTokenGroups::operator=](../vs140/ctokengroups--operator-=.md)|Assignment operator.|  
  
## Remarks  
 An [access token](http://msdn.microsoft.com/library/windows/desktop/aa374909) is an object that describes the security context of a process or thread and is allocated to each user logged onto a Windows NT or Windows 2000 system.  
  
 The **CTokenGroups** class is a wrapper for the [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure, containing information about the group security identifiers (SIDs) in an access token.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="ctokengroups__add">\</a>  CTokenGroups::Add  
 Adds a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or existing **TOKEN_GROUPS** structure to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A [CSid](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The attributes to associate with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 *rTokenGroups*  
 A [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure.  
  
### Remarks  
 These methods add one or more <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects and their associated attributes to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokengroups__ctokengroups">\</a>  CTokenGroups::CTokenGroups  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object or [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure with which to construct the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object can optionally be created using a **TOKEN_GROUPS** structure or a previously defined <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokengroups___dtorctokengroups">\</a>  CTokenGroups::~CTokenGroups  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The destructor frees all allocated resources.  
  
##  \<a name="ctokengroups__delete">\</a>  CTokenGroups::Delete  
 Deletes a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and its associated attributes from the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object for which the security identifier (SID) and attributes should be removed.  
  
### Return Value  
 Returns true if the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is removed, false otherwise.  
  
##  \<a name="ctokengroups__deleteall">\</a>  CTokenGroups::DeleteAll  
 Deletes all <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects and their associated attributes from the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="ctokengroups__getcount">\</a>  CTokenGroups::GetCount  
 Returns the number of <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> objects contained in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of [CSid](../vs140/csid-class.md) objects and their associated attributes contained in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokengroups__getlength">\</a>  CTokenGroups::GetLength  
 Returns the size of the **CTokenGroup** object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 Returns the total size of the **CTokenGroup** object, in bytes.  
  
##  \<a name="ctokengroups__getptoken_groups">\</a>  CTokenGroups::GetPTOKEN_GROUPS  
 Retrieves a pointer to the **TOKEN_GROUPS** structure.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Retrieves a pointer to the [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure belonging to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> access token object.  
  
##  \<a name="ctokengroups__getsidsandattributes">\</a>  CTokenGroups::GetSidsAndAttributes  
 Retrieves the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> objects and (optionally) the attributes belonging to the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Pointer to an array of [CSid](../vs140/csid-class.md) objects.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to an array of DWORDs. If this parameter is omitted or NULL, the attributes are not retrieved.  
  
### Remarks  
 This method will enumerate all of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> objects contained in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object and place them and (optionally) the attribute flags into array objects.  
  
##  \<a name="ctokengroups__lookupsid">\</a>  CTokenGroups::LookupSid  
 Retrieves the attributes associated with a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The [CSid](../vs140/csid-class.md) object.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Pointer to a DWORD which will accept the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object's attribute. If omitted or NULL, the attribute will not be retrieved.  
  
### Return Value  
 Returns true if the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is found, false otherwise.  
  
### Remarks  
 Setting <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to NULL provides a way of confirming the existence of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> without accessing the attribute. Note that this method should not be used to check access rights as incorrect results may occur under Windows 2000. Applications should instead use the [CAccessToken::CheckTokenMembership](../vs140/caccesstoken--checktokenmembership.md) method.  
  
##  \<a name="ctokengroups__operator__eq">\</a>  CTokenGroups::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object or [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure to assign to the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
##  \<a name="ctokengroups__operator_const_token_groups__star">\</a>  CTokenGroups::operator const TOKEN_GROUPS *  
 Casts a value to a pointer to the **TOKEN_GROUPS** structure.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 Casts a value to a pointer to the [TOKEN_GROUPS](http://msdn.microsoft.com/library/windows/desktop/aa379624) structure.  
  
## See Also  
 [Security Sample](../vs140/visual-c---samples.md)   
 [CSid Class](../vs140/csid-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Security Global Functions](../vs140/security-global-functions.md)