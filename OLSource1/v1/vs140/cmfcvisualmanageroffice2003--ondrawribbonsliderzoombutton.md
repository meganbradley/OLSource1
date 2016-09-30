---
title: "CMFCVisualManagerOffice2003::OnDrawRibbonSliderZoomButton"
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
  - "CMFCVisualManagerOffice2003.OnDrawRibbonSliderZoomButton"
  - "OnDrawRibbonSliderZoomButton"
  - "CMFCVisualManagerOffice2003::OnDrawRibbonSliderZoomButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonSliderZoomButton method"
ms.assetid: 60562083-0b4b-44a4-81b1-a49b482f698a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::OnDrawRibbonSliderZoomButton
The framework calls this method when it draws the zoom buttons for a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonSlider](../vs140/cmfcribbonslider-class.md) object. The framework draws this ribbon slider.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the zoom buttons on the ribbon slider.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the framework should draw the left button with a "**-**" for zoom out, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the framework should draw the right button with a "**+**" for zoom in.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is highlighted.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is pressed.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the button is unavailable.  
  
## Remarks  
 By default, the zoom buttons on the ribbon slider are a circle with either a **+** or **-** sign in the center. To customize the appearance of zoom buttons, override this method in a derived visual manager.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)