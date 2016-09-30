---
title: "MFC ActiveX Controls: Painting an ActiveX Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC ActiveX controls, painting"
  - "MFC ActiveX controls, optimizing"
ms.assetid: 25fff9c0-4dab-4704-aaae-8dfb1065dee3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Painting an ActiveX Control
This article describes the ActiveX control painting process and how you can alter paint code to optimize the process. (See [Optimizing Control Drawing](../vs140/optimizing-control-drawing.md) for techniques on how to optimize drawing by not having controls individually restore previously selected GDI objects. After all of the controls have been drawn, the container can automatically restore the original objects.)  
  
 Examples in this article are from a control created by the MFC ActiveX Control Wizard with default settings. For more information on creating a skeleton control application using the MFC ActiveX Control Wizard, see the article [MFC ActiveX Control Wizard](../vs140/mfc-activex-control-wizard.md).  
  
 The following topics are covered:  
  
-   [The overall process for painting a control and the code created by the ActiveX Control Wizard to support painting](#_core_the_painting_process_of_an_activex_control)  
  
-   [How to optimize the painting process](#_core_optimizing_your_paint_code)  
  
-   [How to paint your control using metafiles](#_core_painting_your_control_using_metafiles)  
  
##  \<a name="_core_the_painting_process_of_an_activex_control">\</a> The Painting Process of an ActiveX Control  
 When ActiveX controls are initially displayed or are redrawn, they follow a painting process similar to other applications developed using MFC, with one important distinction: ActiveX controls can be in an active or an inactive state.  
  
 An active control is represented in an ActiveX control container by a child window. Like other windows, it is responsible for painting itself when a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> message is received. The control's base class, [COleControl](../vs140/colecontrol-class.md), handles this message in its <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function. This default implementation calls the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function of your control.  
  
 An inactive control is painted differently. When the control is inactive, its window is either invisible or nonexistent, so it can not receive a paint message. Instead, the control container directly calls the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function of the control. This differs from an active control's painting process in that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function is never called.  
  
 As discussed in the preceding paragraphs, how an ActiveX control is updated depends on the state of the control. However, because the framework calls the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function in both cases, you add the majority of your painting code in this member function.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function handles control painting. When a control is inactive, the control container calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, passing the device context of the control container and the coordinates of the rectangular area occupied by the control.  
  
 The rectangle passed by the framework to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function contains the area occupied by the control. If the control is active, the upper-left corner is (0, 0) and the device context passed is for the child window that contains the control. If the control is inactive, the upper-left coordinate is not necessarily (0, 0) and the device context passed is for the control container containing the control.  
  
> [!NOTE]
>  It is important that your modifications to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> do not depend on the rectangle's upper left point being equal to (0, 0) and that you draw only inside the rectangle passed to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Unexpected results can occur if you draw beyond the rectangle's area.  
  
 The default implementation provided by the MFC ActiveX Control Wizard in the control implementation file (.CPP), shown below, paints the rectangle with a white brush and fills the ellipse with the current background color.  
  
 [!code[NVC_MFC_AxUI#1](../vs140/codesnippet/CPP/mfc-activex-controls--painting-an-activex-control_1.cpp)]  
  
> [!NOTE]
>  When painting a control, you should not make assumptions about the state of the device context that is passed as the *pdc* parameter to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function. Occasionally the device context is supplied by the container application and will not necessarily be initialized to the default state. In particular, explicitly select the pens, brushes, colors, fonts, and other resources that your drawing code depends upon.  
  
##  \<a name="_core_optimizing_your_paint_code">\</a> Optimizing Your Paint Code  
 After the control is successfully painting itself, the next step is to optimize the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function.  
  
 The default implementation of ActiveX control painting paints the entire control area. This is sufficient for simple controls, but in many cases repainting the control would be faster if only the portion that needed updating was repainted, instead of the entire control.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function provides an easy method of optimization by passing <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the rectangular area of the control that needs redrawing. Use this area, usually smaller than the entire control area, to speed up the painting process.  
  
##  \<a name="_core_painting_your_control_using_metafiles">\</a> Painting Your Control Using Metafiles  
 In most cases the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function points to a screen device context (DC). However, when printing images of the control or during a print preview session, the DC received for rendering is a special type called a "metafile DC". Unlike a screen DC, which immediately handles requests sent to it, a metafile DC stores requests to be played back at a later time. Some container applications may also choose to render the control image using a metafile DC when in design mode.  
  
 Metafile drawing requests can be made by the container through two interface functions: **IViewObject::Draw** (this function can also be called for non-metafile drawing) and **IDataObject::GetData**. When a metafile DC is passed as one of the parameters, the MFC framework makes a call to [COleControl::OnDrawMetafile](../vs140/colecontrol--ondrawmetafile.md). Because this is a virtual member function, override this function in the control class to do any special processing. The default behavior calls <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 To make sure the control can be drawn in both screen and metafile device contexts, you must use only member functions that are supported in both a screen and a metafile DC. Be aware that the coordinate system may not be measured in pixels.  
  
 Because the default implementation of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> calls the control's <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function, use only member functions that are suitable for both a metafile and a screen device context, unless you override <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. The following lists the subset of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member functions that can be used in both a metafile and a screen device context. For more information on these functions, see class [CDC](../vs140/cdc-class.md) in the *MFC Reference*.  
  
|Arc|BibBlt|Chord|  
|---------|------------|-----------|  
|**Ellipse**|**Escape**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|**Polygon**|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>||  
  
 In addition to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> member functions, there are several other functions that are compatible in a metafile DC. These include [CPalette::AnimatePalette](../vs140/cpalette--animatepalette.md), [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md), and three member functions of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>: [CreateBrushIndirect](../vs140/cbrush--createbrushindirect.md), [CreateDIBPatternBrush](../vs140/cbrush--createdibpatternbrush.md), and [CreatePatternBrush](../vs140/cbrush--createpatternbrush.md).  
  
 Functions that are not recorded in a metafile are: [DrawFocusRect](../vs140/cdc--drawfocusrect.md), [DrawIcon](../vs140/cdc--drawicon.md), [DrawText](../vs140/cdc--drawtext.md), [ExcludeUpdateRgn](../vs140/cdc--excludeupdatergn.md), [FillRect](../vs140/cdc--fillrect.md), [FrameRect](../vs140/cdc--framerect.md), [GrayString](../vs140/cdc--graystring.md), [InvertRect](../vs140/cdc--invertrect.md), [ScrollDC](../vs140/cdc--scrolldc.md), and [TabbedTextOut](../vs140/cdc--tabbedtextout.md). Because a metafile DC is not actually associated with a device, you cannot use SetDIBits, GetDIBits, and CreateDIBitmap with a metafile DC. You can use SetDIBitsToDevice and StretchDIBits with a metafile DC as the destination. [CreateCompatibleDC](../vs140/cdc--createcompatibledc.md), [CreateCompatibleBitmap](../vs140/cbitmap--createcompatiblebitmap.md), and [CreateDiscardableBitmap](../vs140/cbitmap--creatediscardablebitmap.md) are not meaningful with a metafile DC.  
  
 Another point to consider when using a metafile DC is that the coordinate system may not be measured in pixels. For this reason, all your drawing code should be adjusted to fit in the rectangle passed to <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameter. This prevents accidental painting outside the control because <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> represents the size of the control's window.  
  
 After you have implemented metafile rendering for the control, use Test Container to test the metafile. See [Testing Properties and Events with Test Container](../vs140/testing-properties-and-events-with-test-container.md) for information on how to access the test container.  
  
#### To test the control's metafile using Test Container  
  
1.  On the Test Container's **Edit** menu, click **Insert New Control**.  
  
2.  In the **Insert New Control** box, select the control and click **OK**.  
  
     The control will appear in Test container.  
  
3.  On the **Control** menu, click **Draw Metafile**.  
  
     A separate window appears in which the metafile is displayed. You can change the size of this window to see how scaling affects the control's metafile. You can close this window at any time.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)