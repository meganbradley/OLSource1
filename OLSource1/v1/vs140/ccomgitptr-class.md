---
title: "CComGITPtr Class"
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
  - "ATL::CComGITPtr<T>"
  - "CComGITPtr"
  - "ATL.CComGITPtr"
  - "ATL.CComGITPtr<T>"
  - "ATL::CComGITPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComGITPtr class"
ms.assetid: af895acb-525a-4555-bb67-b241b7df515b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr Class
This class provides methods for dealing with interface pointers and the global interface table (GIT).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of the interface pointer to be stored in the GIT.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComGITPtr::CComGITPtr](../vs140/ccomgitptr--ccomgitptr.md)|The constructor.|  
|[CComGITPtr::~CComGITPtr](../vs140/ccomgitptr--~ccomgitptr.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComGITPtr::Attach](../vs140/ccomgitptr--attach.md)|Call this method to register the interface pointer in the global interface table (GIT).|  
|[CComGITPtr::CopyTo](../vs140/ccomgitptr--copyto.md)|Call this method to copy the interface from the global interface table (GIT) to the passed pointer.|  
|[CComGITPtr::Detach](../vs140/ccomgitptr--detach.md)|Call this method to disassociate the interface from the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[CComGITPtr::GetCookie](../vs140/ccomgitptr--getcookie.md)|Call this method to return the cookie from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[CComGITPtr::Revoke](../vs140/ccomgitptr--revoke.md)|Call this method to remove the interface from the global interface table (GIT).|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CComGITPtr::operator DWORD](../vs140/ccomgitptr--operator-dword.md)|Returns the cookie from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[CComGITPtr::operator =](../vs140/ccomgitptr--operator-=.md)|Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CComGITPtr::m_dwCookie](../vs140/ccomgitptr--m_dwcookie.md)|The cookie.|  
  
## Remarks  
 Objects that aggregate the free threaded marshaler and need to use interface pointers obtained from other objects must take extra steps to ensure that the interfaces are correctly marshaled. Typically this involves storing the interface pointers in the GIT and getting the pointer from the GIT each time it is used. The class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is provided to help you use interface pointers stored in the GIT.  
  
> [!NOTE]
>  The global interface table facility is only available on Windows 95 with DCOM version 1.1 and later, Windows 98, Windows NT 4.0 with Service Pack 3 and later, and Windows 2000.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomgitptr__attach">\</a>  CComGITPtr::Attach  
 Call this method to register the interface pointer in the global interface table (GIT).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The interface pointer to be added to the GIT.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The cookie used to identify the interface pointer.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 In debug builds, an assertion error will occur if the GIT is not valid, or if the cookie is equal to NULL.  
  
##  \<a name="ccomgitptr__ccomgitptr">\</a>  CComGITPtr::CComGITPtr  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An interface pointer to be stored in the global interface table (GIT).  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A reference to an existing <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A cookie used to identify the interface pointer.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The source <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object to move data from.  
  
### Remarks  
 Creates a new <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object, optionally using an existing <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 The constructor utilizing <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a move constructor. The data is moved from the source, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and then <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is cleared.  
  
##  \<a name="ccomgitptr___dtorccomgitptr">\</a>  CComGITPtr::~CComGITPtr  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Removes the interface from the global interface table (GIT), using [CComGITPtr::Revoke](../vs140/ccomgitptr--revoke.md).  
  
##  \<a name="ccomgitptr__copyto">\</a>  CComGITPtr::CopyTo  
 Call this method to copy the interface from the global interface table (GIT) to the passed pointer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The pointer which is to receive the interface.  
  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 The interface from the GIT is copied to the passed pointer. The pointer must be released by the caller when it is no longer required.  
  
##  \<a name="ccomgitptr__detach">\</a>  CComGITPtr::Detach  
 Call this method to disassociate the interface from the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the cookie from the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
### Remarks  
 It is up to the caller to remove the interface from the GIT, using [CComGITPtr::Revoke](../vs140/ccomgitptr--revoke.md).  
  
##  \<a name="ccomgitptr__getcookie">\</a>  CComGITPtr::GetCookie  
 Call this method to return the cookie from the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the cookie.  
  
### Remarks  
 The cookie is a variable used to identify an interface and its location.  
  
##  \<a name="ccomgitptr__m_dwcookie">\</a>  CComGITPtr::m_dwCookie  
 The cookie.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The cookie is a member variable used to identify an interface and its location.  
  
##  \<a name="ccomgitptr__operator__eq">\</a>  CComGITPtr::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to an interface.  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A cookie used to identify the interface pointer.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to move data from.  
  
### Return Value  
 Returns the updated <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Assigns a new value to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object, either from an existing object or from a reference to a global interface table.  
  
##  \<a name="ccomgitptr__operator_dword">\</a>  CComGITPtr::operator DWORD  
 Returns the cookie associated with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The cookie is a variable used to identify an interface and its location.  
  
##  \<a name="ccomgitptr__revoke">\</a>  CComGITPtr::Revoke  
 Call this method to remove the current interface from the global interface table (GIT).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
### Remarks  
 Removes the interface from the GIT.  
  
## See Also  
 [Free Threaded Marshaler](../vs140/atl-and-the-free-threaded-marshaler.md)   
 [Accessing Interfaces Across Apartments](http://msdn.microsoft.com/library/windows/desktop/ms682353)   
 [When to Use the Global Interface Table](http://msdn.microsoft.com/library/windows/desktop/ms693729)   
 [Class Overview](../vs140/atl-class-overview.md)