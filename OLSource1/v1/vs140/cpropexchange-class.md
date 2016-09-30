---
title: "CPropExchange Class"
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
  - "CPropExchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropExchange class"
  - "OLE controls, persistence"
  - "controls [MFC], OLE"
ms.assetid: ed872180-e770-4942-892a-92139d501fab
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropExchange Class
Supports the implementation of persistence for your OLE controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPropExchange::ExchangeBlobProp](#cpropexchange__exchangeblobprop)|Exchanges a binary large object (BLOB) property.|  
|[CPropExchange::ExchangeFontProp](#cpropexchange__exchangefontprop)|Exchanges a font property.|  
|[CPropExchange::ExchangePersistentProp](#cpropexchange__exchangepersistentprop)|Exchanges a property between a control and a file.|  
|[CPropExchange::ExchangeProp](#cpropexchange__exchangeprop)|Exchanges properties of any built-in type.|  
|[CPropExchange::ExchangeVersion](#cpropexchange__exchangeversion)|Exchanges the version number of an OLE control.|  
|[CPropExchange::GetVersion](#cpropexchange__getversion)|Retrieves the version number of an OLE control.|  
|[CPropExchange::IsAsynchronous](#cpropexchange__isasynchronous)|Determines if property exchanges are done asynchronously.|  
|[CPropExchange::IsLoading](#cpropexchange__isloading)|Indicates whether properties are being loaded into the control or saved from it.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> does not have a base class.  
  
 Establishes the context and direction of a property exchange.  
  
 Persistence is the exchange of the control's state information, usually represented by its properties, between the control itself and a medium.  
  
 The framework constructs an object derived from <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when it is notified that an OLE control's properties are to be loaded from or stored to persistent storage.  
  
 The framework passes a pointer to this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to your control's <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function. If you used a wizard to create the starter files for your control, your control's <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The base-class version exchanges the control's stock properties; you modify your derived class's version to exchange properties you have added to your control.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can be used to serialize a control's properties or initialize a control's properties upon the load or creation of a control. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member functions of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are able to store properties to and load them from different media.  
  
 For more information on using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, see the article [MFC ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxctl.h  
  
##  \<a name="cpropexchange__exchangeblobprop">\</a>  CPropExchange::ExchangeBlobProp  
 Serializes a property that stores binary large object (BLOB) data.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Pointer to a variable pointing to where the property is stored (variable is typically a member of your class).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Default value for the property.  
  
### Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
### Remarks  
 The property's value is read from or written to, as appropriate, the variable referenced by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization fails.  
  
 The functions **CArchivePropExchange::ExchangeBlobProp**, **CResetPropExchange::ExchangeBlobProp**, and **CPropsetPropExchange::ExchangeBlobProp** override this pure virtual function.  
  
##  \<a name="cpropexchange__exchangefontprop">\</a>  CPropExchange::ExchangeFontProp  
 Exchanges a font property between a storage medium and the control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A reference to a [CFontHolder](../vs140/cfontholder-class.md) object that contains the font property.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A pointer to a                                 [FONTDESC](http://msdn.microsoft.com/library/windows/desktop/ms692782) structure containing values for initializing the default state of the font property when <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is **NULL**.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to the **IFontDisp** interface of a font to be used for initializing the default state of the font property.  
  
### Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
### Remarks  
 If the font property is being loaded from the medium to the control, the font's characteristics are retrieved from the medium and the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object referenced by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is initialized with them. If the font property is being stored, the characteristics in the font object are written to the medium.  
  
 The functions **CArchivePropExchange::ExchangeFontProp**, **CResetPropExchange::ExchangeFontProp**, and **CPropsetPropExchange::ExchangeFontProp** override this pure virtual function.  
  
##  \<a name="cpropexchange__exchangepersistentprop">\</a>  CPropExchange::ExchangePersistentProp  
 Exchanges a property between the control and a file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to a variable containing a pointer to the property's **IUnknown** interface (this variable is typically a member of your class).  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Interface ID of the interface on the property that the control will use.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Default value for the property.  
  
### Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
### Remarks  
 If the property is being loaded from the file to the control, the property is created and initialized from the file. If the property is being stored, its value is written to the file.  
  
 The functions **CArchivePropExchange::ExchangePersistentProp**, **CResetPropExchange::ExchangePersistentProp**, and **CPropsetPropExchange::ExchangePersistentProp** override this pure virtual function.  
  
##  \<a name="cpropexchange__exchangeprop">\</a>  CPropExchange::ExchangeProp  
 Exchanges a property between a storage medium and the control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A symbol specifying the type of the property being exchanged. Possible values are:  
  
|Symbol|Property Type|  
|------------|-------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|**short**|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|**long**|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|**BOOL**|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|**CY**|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|**float**|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|**double**|  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A pointer to the property's value.  
  
 *pvDefault*  
 Pointer to a default value for the property.  
  
### Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
### Remarks  
 If the property is being loaded from the medium to the control, the property's value is retrieved from the medium and stored in the object pointed to by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. If the property is being stored to the medium, the value of the object pointed to by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is written to the medium.  
  
 The functions **CArchivePropExchange::ExchangeProp**, **CResetPropExchange::ExchangeProp**, and **CPropsetPropExchange::ExchangeProp** override this pure virtual function.  
  
##  \<a name="cpropexchange__exchangeversion">\</a>  CPropExchange::ExchangeVersion  
 Called by the framework to handle persistence of a version number.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *dwVersionLoaded*  
 Reference to a variable where the version number of the persistent data being loaded will be stored.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The current version number of the control.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Indicates whether to convert persistent data to the current version or keep it at the same version that was loaded.  
  
### Return Value  
 Nonzero if the function succeeded; 0 otherwise.  
  
##  \<a name="cpropexchange__getversion">\</a>  CPropExchange::GetVersion  
 Call this function to retrieve the version number of the control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The version number of the control.  
  
##  \<a name="cpropexchange__isasynchronous">\</a>  CPropExchange::IsAsynchronous  
 Determines if property exchanges are done asynchronously.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Returns TRUE if properties are exchanged asynchronously, otherwise FALSE.  
  
##  \<a name="cpropexchange__isloading">\</a>  CPropExchange::IsLoading  
 Call this function to determine whether properties are being loaded to the control or saved from it.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if properties are being loaded; otherwise 0.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol-class.md#colecontrol__dopropexchange)