---
title: "CHandle Class"
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
  - "ATL.CHandle"
  - "ATL::CHandle"
  - "CHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHandle class"
ms.assetid: 883e9db5-40ec-4e29-9c74-4dd2ddd2e35d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHandle Class
This class provides methods for creating and using a handle object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHandle::CHandle](../vs140/chandle--chandle.md)|The constructor.|  
|[CHandle::~CHandle](../vs140/chandle--~chandle.md)|The destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHandle::Attach](../vs140/chandle--attach.md)|Call this method to attach the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to an existing handle.|  
|[CHandle::Close](../vs140/chandle--close.md)|Call this method to close a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[CHandle::Detach](../vs140/chandle--detach.md)|Call this method to detach a handle from a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CHandle::operator HANDLE](../vs140/chandle--operator-handle.md)|Returns the value of the stored handle.|  
|[CHandle::operator =](../vs140/chandle--operator-=.md)|Assignment operator.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CHandle::m_h](../vs140/chandle--m_h.md)|The member variable that stores the handle.|  
  
## Remarks  
 A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object can be used whenever a handle is required: the main difference is that the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object will automatically be deleted.  
  
> [!NOTE]
>  Some API functions will use NULL as an empty or invalid handle, while others use INVALID_HANDLE_VALUE. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> only uses NULL and will treat INVALID_HANDLE_VALUE as a real handle. If you call an API which can return INVALID_HANDLE_VALUE, you should check for this value before calling [CHandle::Attach](../vs140/chandle--attach.md) or passing it to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> constructor, and instead pass NULL.  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="chandle__attach">\</a>  CHandle::Attach  
 Call this method to attach the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object to an existing handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will take ownership of the handle <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Remarks  
 Assigns the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> handle. In debugs builds, an ATLASSERT will be raised if <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is NULL. No other check as to the validity of the handle is made.  
  
##  \<a name="chandle__chandle">\</a>  CHandle::CHandle  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An existing handle or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Remarks  
 Creates a new <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object, optionally using an existing handle or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
##  \<a name="chandle___dtorchandle">\</a>  CHandle::~CHandle  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object by calling [CHandle::Close](../vs140/chandle--close.md).  
  
##  \<a name="chandle__close">\</a>  CHandle::Close  
 Call this method to close a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Closes an open object handle. If the handle is NULL, which will be the case if **Close** has already been called, an ATLASSERT will be raised in debug builds.  
  
##  \<a name="chandle__detach">\</a>  CHandle::Detach  
 Call this method to detach a handle from a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns the handle being detached.  
  
### Remarks  
 Releases ownership of the handle.  
  
##  \<a name="chandle__m_h">\</a>  CHandle::m_h  
 The member variable that stores the handle.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="chandle__operator__eq">\</a>  CHandle::operator =  
 The assignment operator.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> will take ownership of the handle <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
### Return Value  
 Returns a reference to the new <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
### Remarks  
 If the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object currently contains a handle, it will be closed. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object being passed in will have its handle reference set to NULL. This ensures that two <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects will never contain the same active handle.  
  
##  \<a name="chandle__operator_handle">\</a>  CHandle::operator HANDLE  
 Returns the value of the stored handle.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Returns the value stored in [CHandle::m_h](../vs140/chandle--m_h.md).  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)