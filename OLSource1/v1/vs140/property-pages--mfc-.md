---
title: "Property Pages (MFC)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vc.mfc.macros
dev_langs: 
  - C++
helpviewer_keywords: 
  - property page data transfer functions in MFC
  - property pages, global MFC functions
ms.assetid: 734f88bc-c776-4136-9b0e-f45c761a45c1
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Property Pages (MFC)
Property pages display the current values of specific OLE control properties in a customizable, graphical interface for viewing and editing by supporting a data-mapping mechanism based on dialog data exchange (DDX).  
  
 This data-mapping mechanism maps property page controls to the individual properties of the OLE control. The value of the control property reflects the status or content of the property page control. The mapping between property page controls and properties is specified by **DDP_** function calls in the property page's `DoDataExchange` member function. The following is a list of **DDP_** functions that exchange data entered using the property page of your control:  
  
### Property Page Data Transfer  
  
|||  
|-|-|  
|[DDP_CBIndex](../vs140/ddp_cbindex.md)|Links the selected string's index in a combo box with a control's property.|  
|[DDP_CBString](../vs140/ddp_cbstring.md)|Links the selected string in a combo box with a control's property. The selected string can begin with the same letters as the property's value but does not need to match it fully.|  
|[DDP_CBStringExact](../vs140/ddp_cbstringexact.md)|Links the selected string in a combo box with a control's property. The selected string and the property's string value must match exactly.|  
|[DDP_Check](../vs140/ddp_check.md)|Links a check box in the control's property page with a control's property.|  
|[DDP_LBIndex](../vs140/ddp_lbindex.md)|Links the selected string's index in a list box with a control's property.|  
|[DDP_LBString](../vs140/ddp_lbstring.md)|Links the selected string in a list box with a control's property. The selected string can begin with the same letters as the property's value but need not match it fully.|  
|[DDP_LBStringExact](../vs140/ddp_lbstringexact.md)|Links the selected string in a list box with a control's property. The selected string and the property's string value must match exactly.|  
|[DDP_PostProcessing](../vs140/ddp_postprocessing.md)|Finishes the transfer of property values from your control.|  
|[DDP_Radio](../vs140/ddp_radio.md)|Links a radio button group in the control's property page with a control's property.|  
|[DDP_Text](../vs140/ddp_text.md)|Links a control in the control's property page with a control's property. This function handles several different types of properties, such as **double**, **short**, `BSTR`, and **long**.|  
  
 For more information about the `DoDataExchange` function and property pages, see the article [ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md).  
  
 The following is a list of macros used to create and manage property pages for an OLE control:  
  
### Property Pages  
  
|||  
|-|-|  
|[BEGIN_PROPPAGEIDS](../vs140/begin_proppageids.md)|Begins the list of property page IDs.|  
|[END_PROPPAGEIDS](../vs140/end_proppageids.md)|Ends the list of property page IDs.|  
|[PROPPAGEID](../vs140/proppageid.md)|Declares a property page of the control class.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)