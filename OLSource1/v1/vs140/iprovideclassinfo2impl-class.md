---
title: "IProvideClassInfo2Impl Class"
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
  - "IProvideClassInfo2"
  - "ATL.IProvideClassInfo2Impl"
  - "IProvideClassInfo2Impl"
  - "ATL::IProvideClassInfo2Impl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IProvideClassInfo2Impl class"
  - "IProvideClassInfo2 ATL implementation"
  - "class information, ATL"
ms.assetid: d74956e8-9c69-4cba-b99d-ca1ac031bb9d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IProvideClassInfo2Impl Class
This class provides a default implementation of the [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) and [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) methods.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pcoclsid*  
 A pointer to the coclass' identifier.  
  
 *psrcid*  
 A pointer to the identifier for the coclass' default outgoing dispinterface.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the LIBID of the type library that contains information about the interface. By default, the server-level type library is passed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The major version of the type library. The default value is 1.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The minor version of the type library. The default value is 0.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The class used to manage the coclass' type information. The default value is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Members  
  
### Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::IProvideClassInfo2Impl](../vs140/iprovideclassinfo2impl--iprovideclassinfo2impl.md)|Constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::GetClassInfo](../vs140/iprovideclassinfo2impl--getclassinfo.md)|Retrieves an **ITypeInfo** pointer to the coclass' type information.|  
|[IProvideClassInfo2Impl::GetGUID](../vs140/iprovideclassinfo2impl--getguid.md)|Retrieves the GUID for the object's outgoing dispinterface.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[IProvideClassInfo2Impl::_tih](../vs140/iprovideclassinfo2impl--_tih.md)|Manages the type information for the coclass.|  
  
## Remarks  
 The [IProvideClassInfo2](http://msdn.microsoft.com/library/windows/desktop/ms693764) interface extends [IProvideClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms687303) by adding the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method. This method allows a client to retrieve an object's outgoing interface IID for its default event set. Class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> provides a default implementation of the **IProvideClassInfo** and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> methods.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> contains a static member of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that manages the type information for the coclass.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="iprovideclassinfo2impl__getclassinfo">\</a>  IProvideClassInfo2Impl::GetClassInfo  
 Retrieves an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pointer to the coclass' type information.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 See [IProvideClassInfo::GetClassInfo](http://msdn.microsoft.com/library/windows/desktop/ms690192) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iprovideclassinfo2impl__getguid">\</a>  IProvideClassInfo2Impl::GetGUID  
 Retrieves the GUID for the object's outgoing dispinterface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 See [IProvideClassInfo2::GetGUID](http://msdn.microsoft.com/library/windows/desktop/ms679721) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iprovideclassinfo2impl__iprovideclassinfo2impl">\</a>  IProvideClassInfo2Impl::IProvideClassInfo2Impl  
 The constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> on the [_tih](../vs140/iprovideclassinfo2impl--_tih.md) member. The destructor calls **Release**.  
  
##  \<a name="iprovideclassinfo2impl___tih">\</a>  IProvideClassInfo2Impl::_tih  
 This static data member is an instance of the class template parameter, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, which by default is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> manages the type information for the coclass.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)