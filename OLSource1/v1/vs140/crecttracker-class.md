---
title: "CRectTracker Class"
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
  - "CRectTracker"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "displaying items"
  - "CRectTracker class"
  - "resizing items"
ms.assetid: 99caa7f2-3c0d-4a42-bbee-e5d1d342d4ee
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRectTracker Class
Allows an item to be displayed, moved, and resized in different fashions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRectTracker::CRectTracker](#crecttracker__crecttracker)|Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRectTracker::AdjustRect](#crecttracker__adjustrect)|Called when the rectangle is resized.|  
|[CRectTracker::Draw](#crecttracker__draw)|Renders the rectangle.|  
|[CRectTracker::DrawTrackerRect](#crecttracker__drawtrackerrect)|Called when drawing the border of a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[CRectTracker::GetHandleMask](#crecttracker__gethandlemask)|Called to get the mask of a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>item's resize handles.|  
|[CRectTracker::GetTrueRect](#crecttracker__gettruerect)|Returns width and height of rectangle, including resize handles.|  
|[CRectTracker::HitTest](#crecttracker__hittest)|Returns the current position of the cursor related to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CRectTracker::NormalizeHit](#crecttracker__normalizehit)|Normalizes a hit-test code.|  
|[CRectTracker::OnChangedRect](#crecttracker__onchangedrect)|Called when the rectangle has been resized or moved.|  
|[CRectTracker::SetCursor](#crecttracker__setcursor)|Sets the cursor, depending on its position over the rectangle.|  
|[CRectTracker::Track](#crecttracker__track)|Allows the user to manipulate the rectangle.|  
|[CRectTracker::TrackRubberBand](#crecttracker__trackrubberband)|Allows the user to "rubber-band" the selection.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CRectTracker::m_nHandleSize](#crecttracker__m_nhandlesize)|Determines size of resize handles.|  
|[CRectTracker::m_nStyle](#crecttracker__m_nstyle)|Current style(s) of the tracker.|  
|[CRectTracker::m_rect](#crecttracker__m_rect)|Current position (in pixels) of the rectangle.|  
|[CRectTracker::m_sizeMin](#crecttracker__m_sizemin)|Determines minimum rectangle width and height.|  
  
## Remarks  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> does not have a base class.  
  
 Although the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class is designed to allow the user to interact with OLE items by using a graphical interface, its use is not restricted to OLE-enabled applications. It can be used anywhere such a user interface is required.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> borders can be solid or dotted lines. The item can be given a hatched border or overlaid with a hatched pattern to indicate different states of the item. You can place eight resize handles on either the outside or the inside border of the item. (For an explanation of the resize handles, see [GetHandleMask](#crecttracker__gethandlemask).) Finally, a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> allows you to change the orientation of an item during resizing.  
  
 To use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, construct a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object and specify which display states are initialized. You can then use this interface to give the user visual feedback on the current status of the OLE item associated with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
 For more information on using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see the article [Trackers](../vs140/trackers.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="crecttracker__adjustrect">\</a>  CRectTracker::AdjustRect  
 Called by the framework when the tracking rectangle is resized by using a resize handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Index of handle used.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the current size of the rectangle. (The size of a rectangle is given by its height and width.)  
  
### Remarks  
 The default behavior of this function allows the rectangle's orientation to change only when <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> are called with inverting allowed.  
  
 Override this function to control the adjustment of the tracking rectangle during a dragging operation. One method is to adjust the coordinates specified by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> before returning.  
  
 Special features that are not directly supported by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, such as snap-to-grid or keep-aspect-ratio, can be implemented by overriding this function.  
  
##  \<a name="crecttracker__crecttracker">\</a>  CRectTracker::CRectTracker  
 Creates and initializes a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The coordinates of the rectangle object.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies the style of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object. The following styles are supported:  
  
-   **CRectTracker::solidLine** Use a solid line for the rectangle border.  
  
-   **CRectTracker::dottedLine** Use a dotted line for the rectangle border.  
  
-   **CRectTracker::hatchedBorder** Use a hatched pattern for the rectangle border.  
  
-   **CRectTracker::resizeInside** Resize handles located inside the rectangle.  
  
-   **CRectTracker::resizeOutside** Resize handles located outside the rectangle.  
  
-   **CRectTracker::hatchInside** Hatched pattern covers the entire rectangle.  
  
### Remarks  
 The default constructor initializes the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object with the values from <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> and initializes other sizes to system defaults. If the object is created with no parameters, the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> data members are uninitialized.  
  
##  \<a name="crecttracker__draw">\</a>  CRectTracker::Draw  
 Call this function to draw the rectangle's outer lines and inner region.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Pointer to the device context on which to draw.  
  
### Remarks  
 The style of the tracker determines how the drawing is done. See the constructor for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> for more information on the styles available.  
  
##  \<a name="crecttracker__drawtrackerrect">\</a>  CRectTracker::DrawTrackerRect  
 Called by the framework whenever the position of the tracker has changed while inside the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> that contains the rectangle to draw.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Pointer to the window to use in clipping the rectangle.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Pointer to the device context on which to draw.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Pointer to the window on which the drawing will occur.  
  
### Remarks  
 The default implementation makes a call to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, which draws a dotted rectangle.  
  
 Override this function to provide different feedback during the tracking operation.  
  
##  \<a name="crecttracker__gethandlemask">\</a>  CRectTracker::GetHandleMask  
 The framework calls this member function to retrieve the mask for a rectangle's resize handles.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The mask of a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> item's resize handles.  
  
### Remarks  
 The resize handles appear on the sides and corners of the rectangle and allow the user to control the shape and size of the rectangle.  
  
 A rectangle has 8 resize handles numbered 0–7. Each resize handle is represented by a bit in the mask; the value of that bit is 2^                        *n*, where                         *n* is the resize handle number. Bits 0–3 correspond to the corner resize handles, starting at the top left moving clockwise. Bits 4–7 correspond to the side resize handles starting at the top moving clockwise. The following illustration shows a rectangle's resize handles and their corresponding resize handle numbers and values:  
  
 ![Resize handle numbers](../vs140/media/vc35dp1.gif "vc35DP1")  
  
 The default implementation of **GetHandleMask** returns the mask of the bits so that the resize handles appear. If the single bit is on, the corresponding resize handle will be drawn.  
  
 Override this member function to hide or show the indicated resize handles.  
  
##  \<a name="crecttracker__gettruerect">\</a>  CRectTracker::GetTrueRect  
 Call this function to retrieve the coordinates of the rectangle.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> structure that will contain the device coordinates of the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The dimensions of the rectangle include the height and width of any resize handles located on the outer border. Upon returning, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is always a normalized rectangle in device coordinates.  
  
##  \<a name="crecttracker__hittest">\</a>  CRectTracker::HitTest  
 Call this function to find out whether the user has grabbed a resize handle.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The point, in device coordinates, to test.  
  
### Return Value  
 The value returned is based on the enumerated type **CRectTracker::TrackerHit** and can have one of the following values:  
  
-   **CRectTracker::hitNothing** –1  
  
-   **CRectTracker::hitTopLeft** 0  
  
-   **CRectTracker::hitTopRight** 1  
  
-   **CRectTracker::hitBottomRight** 2  
  
-   **CRectTracker::hitBottomLeft** 3  
  
-   **CRectTracker::hitTop** 4  
  
-   **CRectTracker::hitRight** 5  
  
-   **CRectTracker::hitBottom** 6  
  
-   **CRectTracker::hitLeft** 7  
  
-   **CRectTracker::hitMiddle** 8  
  
##  \<a name="crecttracker__m_nhandlesize">\</a>  CRectTracker::m_nHandleSize  
 The size, in pixels, of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> resize handles.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Initialized with the default system value.  
  
##  \<a name="crecttracker__m_rect">\</a>  CRectTracker::m_rect  
 The current position of the rectangle in client coordinates (pixels).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="crecttracker__m_sizemin">\</a>  CRectTracker::m_sizeMin  
 The minimum size of the rectangle.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Both default values, **cx** and **cy**, are calculated from the default system value for the border width. This data member is used only by the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> member function.  
  
##  \<a name="crecttracker__m_nstyle">\</a>  CRectTracker::m_nStyle  
 Current style of the rectangle.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 See [CRectTracker::CRectTracker](#crecttracker__crecttracker) for a list of possible styles.  
  
##  \<a name="crecttracker__normalizehit">\</a>  CRectTracker::NormalizeHit  
 Call this function to convert a potentially inverted handle.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Handle selected by the user.  
  
### Return Value  
 The index of the normalized handle.  
  
### Remarks  
 When <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is called with inverting allowed, it is possible for the rectangle to be inverted on the x-axis, the y-axis, or both. When this happens, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> will return handles that are also inverted with respect to the rectangle. This is inappropriate for drawing cursor feedback because the feedback depends on the screen position of the rectangle, not the portion of the rectangle data structure that will be modified.  
  
##  \<a name="crecttracker__onchangedrect">\</a>  CRectTracker::OnChangedRect  
 Called by the framework whenever the tracker rectangle has changed during a call to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 *rectOld*  
 Contains the old device coordinates of the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object.  
  
### Remarks  
 At the time this function is called, all feedback drawn with <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> has been removed. The default implementation of this function does nothing.  
  
 Override this function when you want to perform any actions after the rectangle has been resized.  
  
##  \<a name="crecttracker__setcursor">\</a>  CRectTracker::SetCursor  
 Call this function to change the cursor shape while it is over the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object's region.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Points to the window that currently contains the cursor.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Results of the previous hit test, from the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> message.  
  
### Return Value  
 Nonzero if the previous hit was over the tracker rectangle; otherwise 0.  
  
### Remarks  
 Call this function from inside the function of your window that handles the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> message (typically <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>).  
  
##  \<a name="crecttracker__track">\</a>  CRectTracker::Track  
 Call this function to display the user interface for resizing the rectangle.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The window object that contains the rectangle.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Device coordinates of the current mouse position relative to the client area.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 If **TRUE**, the rectangle can be inverted along the x-axis or y-axis; otherwise **FALSE**.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 The window that drawing operations will be clipped to. If **NULL**, <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> is used as the clipping rectangle.  
  
### Return Value  
 If the ESC key is pressed, the tracking process is halted, the rectangle stored in the tracker is not altered, and 0 is returned. If the change is committed, by moving the mouse and releasing the left mouse button, the new position and/or size is recorded in the tracker's rectangle and nonzero is returned.  
  
### Remarks  
 This is usually called from inside the function of your application that handles the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> message (typically <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>).  
  
 This function will capture the mouse until the user releases the left mouse button, presses the ESC key, or presses the right mouse button. As the user moves the mouse cursor, the feedback is updated by calling <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> is **TRUE**, the tracking rectangle can be inverted on either the x-axis or y-axis.  
  
##  \<a name="crecttracker__trackrubberband">\</a>  CRectTracker::TrackRubberBand  
 Call this function to do rubber-band selection.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The window object that contains the rectangle.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Device coordinates of the current mouse position relative to the client area.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 If **TRUE,** the rectangle can be inverted along the x-axis or y-axis; otherwise **FALSE**.  
  
### Return Value  
 Nonzero if the mouse has moved and the rectangle is not empty; otherwise 0.  
  
### Remarks  
 It is usually called from inside the function of your application that handles the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> message (typically <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>).  
  
 This function will capture the mouse until the user releases the left mouse button, presses the ESC key, or presses the right mouse button. As the user moves the mouse cursor, the feedback is updated by calling <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 Tracking is performed with a rubber-band-type selection from the lower-right handle. If inverting is allowed, the rectangle can be sized by dragging either up and to the left or down and to the right.  
  
## See Also  
 [MFC Sample TRACKER](../vs140/visual-c---samples.md)   
 [MFC Sample DRAWCLI](../vs140/visual-c---samples.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleResizeBar](../vs140/coleresizebar-class.md)   
 [CRect](../vs140/crect-class.md)   
 [CRectTracker::GetHandleMask](#crecttracker__gethandlemask)