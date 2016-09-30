---
title: "CAutoRevertImpersonation Class"
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
  - "ATL::CAutoRevertImpersonation"
  - "CAutoRevertImpersonation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoRevertImpersonation class"
ms.assetid: 43732849-1940-4bd4-9d52-7a5698bb8838
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoRevertImpersonation Class
This class reverts [CAccessToken](../vs140/caccesstoken-class.md) objects to a nonimpersonating state when it goes out of scope.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoRevertImpersonation::CAutoRevertImpersonation](../vs140/cautorevertimpersonation--cautorevertimpersonation.md)|Constructs an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object|  
|[CAutoRevertImpersonation::~CAutoRevertImpersonation](../vs140/cautorevertimpersonation--~cautorevertimpersonation.md)|Destroys the object and reverts access token impersonation.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoRevertImpersonation::Attach](../vs140/cautorevertimpersonation--attach.md)|Automates the impersonation reversion of an access token.|  
|[CAutoRevertImpersonation::Detach](../vs140/cautorevertimpersonation--detach.md)|Cancels the automatic impersonation reversion.|  
|[CAutoRevertImpersonation::GetAccessToken](../vs140/cautorevertimpersonation--getaccesstoken.md)|Retrieves the access token current associated with this object.|  
  
## Remarks  
 An [access token](http://msdn.microsoft.com/library/windows/desktop/aa374909) is an object that describes the security context of a process or thread and is allocated to each user logged onto a Windows NT or Windows 2000 system. These access tokens can be represented with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class.  
  
 It is sometimes necessary to impersonate access tokens. This class is provided as a convenience, but it does not perform the impersonation of access tokens; it only performs the automatic reversion to a nonimpersonated state. This is because token access impersonation can be performed several different ways.  
  
 For an introduction to the access control model in Windows, see [Access Control](http://msdn.microsoft.com/library/windows/desktop/aa374860) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlsecurity.h  
  
##  \<a name="cautorevertimpersonation__attach">\</a>  CAutoRevertImpersonation::Attach  
 Automates the impersonation reversion of an access token.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The address of the [CAccessToken](../vs140/caccesstoken-class.md) object to be reverted automatically  
  
### Remarks  
 This method should only be used if the [CAutoRevertImpersonation](../vs140/cautorevertimpersonation-class.md) object was created with a NULL <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointer, or if [Detach](../vs140/cautorevertimpersonation--detach.md) was called previously. For simple cases, it is not necessary to use this method.  
  
##  \<a name="cautorevertimpersonation__cautorevertimpersonation">\</a>  CAutoRevertImpersonation::CAutoRevertImpersonation  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The address of the [CAccessToken](../vs140/caccesstoken-class.md) object to be reverted automatically.  
  
### Remarks  
 The actual impersonation of the access token should be performed separately from and preferably before the creation of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. This impersonation will be reverted automatically when the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object goes out of scope.  
  
##  \<a name="cautorevertimpersonation___dtorcautorevertimpersonation">\</a>  CAutoRevertImpersonation::~CAutoRevertImpersonation  
 Destroys the object and reverts access token impersonation.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Reverts any impersonation currently in effect for the [CAccessToken](../vs140/caccesstoken-class.md) object provided either at construction or through the [Attach](../vs140/cautorevertimpersonation--attach.md) method. If no <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is associated, the destructor has no effect.  
  
##  \<a name="cautorevertimpersonation__detach">\</a>  CAutoRevertImpersonation::Detach  
 Cancels the automatic impersonation reversion.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The address of the previously associated [CAccessToken](../vs140/caccesstoken-class.md), or NULL if no association existed.  
  
### Remarks  
 Calling **Detach** prevents the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object from reverting any impersonation currently in effect for the [CAccessToken](../vs140/caccesstoken-class.md) object associated with this object. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can then be destroyed with no effect or reassociated to the same or another <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object using [Attach](../vs140/cautorevertimpersonation--attach.md).  
  
##  \<a name="cautorevertimpersonation__getaccesstoken">\</a>  CAutoRevertImpersonation::GetAccessToken  
 Retrieves the access token current associated with this object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The address of the previously associated [CAccessToken](../vs140/caccesstoken-class.md), or NULL if no association existed.  
  
### Remarks  
 If this method is called for the purposes that include the reversion of an impersonation of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object, the [Detach](../vs140/cautorevertimpersonation--detach.md) method should be used instead.  
  
## See Also  
 [ATLSecurity Sample](../vs140/visual-c---samples.md)   
 [Access Tokens](http://msdn.microsoft.com/library/windows/desktop/aa374909)   
 [Class Overview](../vs140/atl-class-overview.md)