---
title: "CComClassFactory2 Class"
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
  - "ATL::CComClassFactory2<license>"
  - "CComClassFactory2"
  - "ATL.CComClassFactory2<license>"
  - "ATL::CComClassFactory2"
  - "ATL.CComClassFactory2"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComClassFactory2 class"
ms.assetid: 19b66fd6-b9ed-47a0-822c-8132184f5a3e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComClassFactory2 Class
This class implements the [IClassFactory2](http://msdn.microsoft.com/library/windows/desktop/ms692720) interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *license*  
 A class that implements the following static functions:  
  
-   **static BOOL VerifyLicenseKey( BSTR**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **);**  
  
-   **static BOOL GetLicenseKey( DWORD**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **, BSTR\***  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **);**  
  
-   **static BOOL IsLicenseValid( );**  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CComClassFactory2::CreateInstance](../vs140/ccomclassfactory2--createinstance.md)|Creates an object of the specified CLSID.|  
|[CComClassFactory2::CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md)|Given a license key, creates an object of the specified CLSID.|  
|[CComClassFactory2::GetLicInfo](../vs140/ccomclassfactory2--getlicinfo.md)|Retrieves information describing the licensing capabilities of the class factory.|  
|[CComClassFactory2::LockServer](../vs140/ccomclassfactory2--lockserver.md)|Locks the class factory in memory.|  
|[CComClassFactory2::RequestLicKey](../vs140/ccomclassfactory2--requestlickey.md)|Creates and returns a license key.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> implements the [IClassFactory2](http://msdn.microsoft.com/library/windows/desktop/ms692720) interface, which is an extension of [IClassFactory](http://msdn.microsoft.com/library/windows/desktop/ms694364).                 **IClassFactory2** controls object creation through a license. A class factory executing on a licensed machine can provide a run-time license key. This license key allows an application to instantiate objects when a full machine license does not exist.  
  
 ATL objects normally acquire a class factory by deriving from [CComCoClass](../vs140/ccomcoclass-class.md). This class includes the macro [DECLARE_CLASSFACTORY](../vs140/declare_classfactory.md), which declares [CComClassFactory](../vs140/ccomclassfactory-class.md) as the default class factory. To use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, specify the [DECLARE_CLASSFACTORY2](../vs140/declare_classfactory2.md) macro in your object's class definition. For example:  
  
 [!code[NVC_ATL_COM#2](../vs140/codesnippet/CPP/ccomclassfactory2-class_1.h)]  
  
 **CMyLicense**, the template parameter to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, must implement the static functions <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The following is an example of a simple license class:  
  
 [!code[NVC_ATL_COM#3](../vs140/codesnippet/CPP/ccomclassfactory2-class_2.h)]  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> derives from both **CComClassFactory2Base** and *license*.                 **CComClassFactory2Base**, in turn, derives from **IClassFactory2** and **CComObjectRootEx\< CComGlobalsThreadModel >**.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 [CComObjectRootEx](../vs140/ccomobjectrootex-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcom.h  
  
##  \<a name="ccomclassfactory2__createinstance">\</a>  CComClassFactory2::CreateInstance  
 Creates an object of the specified CLSID and retrieves an interface pointer to this object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> must be **NULL**.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is non-                                **NULL**, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer identified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value.  
  
### Remarks  
 Requires the machine to be fully licensed. If a full machine license does not exist, call [CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md).  
  
##  \<a name="ccomclassfactory2__createinstancelic">\</a>  CComClassFactory2::CreateInstanceLic  
 Similar to [CreateInstance](../vs140/ccomclassfactory2--createinstance.md), except that <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> requires a license key.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 [in] If the object is being created as part of an aggregate, then <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> must be the outer unknown. Otherwise, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> must be **NULL**.  
  
 *pUnkReserved*  
 [in] Not used. Must be **NULL**.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 [in] The IID of the requested interface. If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is non-                                **NULL**, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> must be **IID_IUnknown**.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 [in] The run-time license key previously obtained from a call to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. This key is required to create the object.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 [out] A pointer to the interface pointer specified by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. If the object does not support this interface, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is set to **NULL**.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> value.  
  
### Remarks  
 You can obtain a license key using [RequestLicKey](../vs140/ccomclassfactory2--requestlickey.md). In order to create an object on an unlicensed machine, you must call <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
##  \<a name="ccomclassfactory2__getlicinfo">\</a>  CComClassFactory2::GetLicInfo  
 Fills a [LICINFO](http://msdn.microsoft.com/library/windows/desktop/ms690590) structure with information that describes the class factory's licensing capabilities.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *pLicInfo*  
 [out] Pointer to a **LICINFO** structure.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> member of this structure indicates whether, given a license key, the class factory allows objects to be created on an unlicensed machine. The *fLicVerified* member indicates whether a full machine license exists.  
  
##  \<a name="ccomclassfactory2__lockserver">\</a>  CComClassFactory2::LockServer  
 Increments and decrements the module lock count by calling **_Module::Lock** and **_Module::Unlock**, respectively.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 [in] If **TRUE**, the lock count is incremented; otherwise, the lock count is decremented.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> value.  
  
### Remarks  
 **_Module** refers to the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
 Calling <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> allows a client to hold onto a class factory so that multiple objects can be quickly created.  
  
##  \<a name="ccomclassfactory2__requestlickey">\</a>  CComClassFactory2::RequestLicKey  
 Creates and returns a license key, provided that the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> member of the [LICINFO](http://msdn.microsoft.com/library/windows/desktop/ms690590) structure is **TRUE**.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 [in] Not used. Must be zero.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 [out] Pointer to the license key.  
  
### Return Value  
 A standard <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> value.  
  
### Remarks  
 A license key is required for calling [CreateInstanceLic](../vs140/ccomclassfactory2--createinstancelic.md) to create an object on an unlicensed machine. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is **FALSE**, then objects can only be created on a fully licensed machine.  
  
 Call [GetLicInfo](../vs140/ccomclassfactory2--getlicinfo.md) to retrieve the value of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
## See Also  
 [CComClassFactoryAutoThread Class](../vs140/ccomclassfactoryautothread-class.md)   
 [CComClassFactorySingleton Class](../vs140/ccomclassfactorysingleton-class.md)   
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComGlobalsThreadModel](../vs140/ccomglobalsthreadmodel.md)   
 [Class Overview](../vs140/atl-class-overview.md)