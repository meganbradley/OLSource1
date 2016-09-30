---
title: "IObjectSafetyImpl Class"
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
  - "IObjectSafetyImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "controls [ATL], safe"
  - "safe for scripting and initialization (controls)"
  - "IObjectSafety, ATL implementation"
  - "IObjectSafetyImpl class"
ms.assetid: 64e32082-d910-4a8a-a5bf-ebed9145359d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IObjectSafetyImpl Class
This class provides a default implementation of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interface to allow a client to retrieve and set an object's safety levels.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Your class, derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 *dwSupportedSafety*  
 Specifies the supported safety options for the control. Can be one of the following values:  
  
-   **INTERFACESAFE_FOR_UNTRUSTED_CALLER** The interface identified by the [SetInterfaceSafetyOptions](../vs140/iobjectsafetyimpl--setinterfacesafetyoptions.md) parameter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should be made safe for scripting.  
  
-   **INTERFACESAFE_FOR_UNTRUSTED_DATA** The interface identified by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should be made safe for untrusted data during initialization.  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IObjectSafetyImpl::GetInterfaceSafetyOptions](../vs140/iobjectsafetyimpl--getinterfacesafetyoptions.md)|Retrieves the safety options supported by the object, as well as the safety options currently set for the object.|  
|[IObjectSafetyImpl::SetInterfaceSafetyOptions](../vs140/iobjectsafetyimpl--setinterfacesafetyoptions.md)|Makes the object safe for initialization or scripting.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[IObjectSafetyImpl::m_dwCurrentSafety](../vs140/iobjectsafetyimpl--m_dwcurrentsafety.md)|Stores the object's current safety level.|  
  
## Remarks  
 Class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> provides a default implementation of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface allows a client to retrieve and set an object's safety levels. For example, a web browser can call **IObjectSafety::SetInterfaceSafetyOptions** to make a control safe for initialization or safe for scripting.  
  
 Note that using the [IMPLEMENTED_CATEGORY](../vs140/implemented_category.md) macro with the **CATID_SafeForScripting** and **CATID_SafeForInitializing** component categories provides an alternative way of specifying that a component is safe.  
  
 **Related Articles** [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md), [Creating an ATL Project](../vs140/creating-an-atl-project.md)  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlctl.h  
  
##  \<a name="iobjectsafetyimpl__getinterfacesafetyoptions">\</a>  IObjectSafetyImpl::GetInterfaceSafetyOptions  
 Retrieves the safety options supported by the object, as well as the safety options currently set for the object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The implementation returns the appropriate values for any interface supported by the object's implementation of **IUnknown::QueryInterface**.  
  
> [!IMPORTANT]
>  Any object that supports <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is responsible for its own security, and that of any object it delegates. The programmer must take into account issues arising from running code in the user's context, cross-site scripting and perform suitable zone checking.  
  
 See [IObjectSafety::GetInterfaceSafetyOptions](https://msdn.microsoft.com/en-us/library/aa768223.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="iobjectsafetyimpl__m_dwcurrentsafety">\</a>  IObjectSafetyImpl::m_dwCurrentSafety  
 Stores the object's current safety level.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="iobjectsafetyimpl__setinterfacesafetyoptions">\</a>  IObjectSafetyImpl::SetInterfaceSafetyOptions  
 Makes the object safe for initialization or scripting by setting the [m_dwCurrentSafety](../vs140/iobjectsafetyimpl--m_dwcurrentsafety.md) member to the appropriate value.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The implementation returns **E_NOINTERFACE** for any interface not supported by the object's implementation of **IUnknown::QueryInterface**.  
  
> [!IMPORTANT]
>  Any object that supports <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is responsible for its own security, and that of any object it delegates. The programmer must take into account issues arising from running code in the user's context, cross-site scripting and perform suitable zone checking.  
  
 See [IObjectSafety::SetInterfaceSafetyOptions](https://msdn.microsoft.com/en-us/library/aa768225.aspx) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [IObjectSafety Interface](https://msdn.microsoft.com/en-us/library/aa768224.aspx)   
 [Class Overview](../vs140/atl-class-overview.md)