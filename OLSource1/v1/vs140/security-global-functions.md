---
title: "Security Global Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SIDs [C++], modifying SID objects"
  - "ACL object global functions"
  - "security IDs [C++]"
ms.assetid: 6a584bfe-16b7-47f4-8439-9c789c41567a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Security Global Functions
These functions provide support for modifying SID and ACL objects.  
  
> [!IMPORTANT]
>  The functions listed in the following table cannot be used in applications that execute in the                 [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
|||  
|-|-|  
|[AtlGetDacl](../vs140/atlgetdacl.md)|Call this function to retrieve the discretionary access-control list (DACL) information of a specified object.|  
|[AtlSetDacl](../vs140/atlsetdacl.md)|Call this function to set the discretionary access-control list (DACL) information of a specified object.|  
|[AtlGetGroupSid](../vs140/atlgetgroupsid.md)|Call this function to retrieve the group security identifier (SID) of an object.|  
|[AtlSetGroupSid](../vs140/atlsetgroupsid.md)|Call this function to set the group security identifier (SID) of an object.|  
|[AtlGetOwnerSid](../vs140/atlgetownersid.md)|Call this function to retrieve the owner security identifier (SID) of an object.|  
|[AtlSetOwnerSid](../vs140/atlsetownersid.md)|Call this function to set the owner security identifier (SID) of an object.|  
|[AtlGetSacl](../vs140/atlgetsacl.md)|Call this function to retrieve the system access-control list (SACL) information of a specified object.|  
|[AtlSetSacl](../vs140/atlsetsacl.md)|Call this function to set the system access-control list (SACL) information of a specified object.|  
|[AtlGetSecurityDescriptor](../vs140/atlgetsecuritydescriptor.md)|Call this function to retrieve the security descriptor of a given object.|  
  
##  \<a name="atlgetdacl">\</a>  AtlGetDacl  
 Call this function to retrieve the discretionary access-control list (DACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Handle to the object for which to retrieve the security information.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Pointer to a DACL object which will contain the retrieved security information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if either                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is invalid                        *.*  
  
##  \<a name="atlsetdacl">\</a>  AtlSetDacl  
 Call this function to set the discretionary access-control list (DACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Handle to the object for which to set security information.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The DACL containing the new security information.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The inheritance flow control. This value can be 0 (the default), PROTECTED_DACL_SECURITY_INFORMATION or UNPROTECTED_DACL_SECURITY_INFORMATION.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is invalid, or if                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is not one of the three permitted values.  
  
##  \<a name="atlgetgroupsid">\</a>  AtlGetGroupSid  
 Call this function to retrieve the group security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Handle to the object from which to retrieve security information.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Pointer to a                                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object which will contain the new security information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="atlsetgroupsid">\</a>  AtlSetGroupSid  
 Call this function to set the group security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Handle to the object for which to set security information.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object containing the new security information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="atlgetownersid">\</a>  AtlGetOwnerSid  
 Call this function to retrieve the owner security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Handle to the object from which to retrieve security information.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Pointer to a                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object which will contain the new security information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="atlsetownersid">\</a>  AtlSetOwnerSid  
 Call this function to set the owner security identifier (SID) of an object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Handle to the object for which to set security information.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object containing the new security information.  
  
### Return Value  
 Returns true on success, false on failure.  
  
##  \<a name="atlgetsacl">\</a>  AtlGetSacl  
 Call this function to retrieve the system access-control list (SACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Handle to the object from which to retrieve the security information.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Pointer to a SACL object which will contain the retrieved security information.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> set to false.  
  
##  \<a name="atlsetsacl">\</a>  AtlSetSacl  
 Call this function to set the system access-control list (SACL) information of a specified object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Handle to the object for which to set security information.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> parameter.  
  
 *rSacl*  
 The SACL containing the new security information.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The inheritance flow control. This value can be 0 (the default), PROTECTED_SACL_SECURITY_INFORMATION or UNPROTECTED_SACL_SECURITY_INFORMATION.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is invalid, or if                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is not one of the three permitted values.  
  
 If                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> set to false.  
  
##  \<a name="atlgetsecuritydescriptor">\</a>  AtlGetSecurityDescriptor  
 Call this function to retrieve the security descriptor of a given object.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the                     [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *pszObjectName*  
 Pointer to a null-terminated string that specifies the name of the object from which to retrieve security information.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies a value from the                                 [SE_OBJECT_TYPE](http://msdn.microsoft.com/library/windows/desktop/aa379593) enumeration that indicates the type of object identified by the                                 *pszObjectName* parameter.  
  
 *pSecurityDescriptor*  
 The object which receives the requested security descriptor.  
  
 *requestedInfo*  
 A set of                                 [SECURITY_INFORMATION](http://msdn.microsoft.com/library/windows/desktop/aa379573) bit flags that indicate the type of security information to retrieve. This parameter can be a combination of the following values.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 If true, the function will attempt to enable the SE_SECURITY_NAME privilege, and restore it on completion.  
  
### Return Value  
 Returns true on success, false on failure.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is to be called many times on many different objects, it will be more efficient to enable the SE_SECURITY_NAME privilege once before calling the function, with                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> set to false.  
  
## See Also  
 [ATL Functions](../vs140/atl-functions.md)