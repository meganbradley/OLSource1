---
title: "CDC Class"
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
  - "CDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Windows [C++], device contexts"
  - "Windows 95 [C++], screen coordinates"
  - "device contexts [C++], CDC class"
  - "screen coordinates in device contexts"
  - "coordinates in Windows 95/98 [C++]"
  - "Windows 98 [C++], screen coordinates"
  - "CDC class"
ms.assetid: 715b3334-cb2b-4c9c-8067-02eb7c66c8b2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC Class
Defines a class of device-context objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDC::CDC](#cdc__cdc)|Constructs a <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDC::AbortDoc](#cdc__abortdoc)|Terminates the current print job, erasing everything the application has written to the device since the last call of the <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> member function.|  
|[CDC::AbortPath](#cdc__abortpath)|Closes and discards any paths in the device context.|  
|[CDC::AddMetaFileComment](#cdc__addmetafilecomment)|Copies the comment from a buffer into a specified enhanced-format metafile.|  
|[CDC::AlphaBlend](#cdc__alphablend)|Displays bitmaps that have transparent or semitransparent pixels.|  
|[CDC::AngleArc](#cdc__anglearc)|Draws a line segment and an arc, and moves the current position to the ending point of the arc.|  
|[CDC::Arc](#cdc__arc)|Draws an elliptical arc.|  
|[CDC::ArcTo](#cdc__arcto)|Draws an elliptical arc. This function is similar to <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>, except that the current position is updated.|  
|[CDC::Attach](#cdc__attach)|Attaches a Windows device context to this <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> object.|  
|[CDC::BeginPath](#cdc__beginpath)|Opens a path bracket in the device context.|  
|[CDC::BitBlt](#cdc__bitblt)|Copies a bitmap from a specified device context.|  
|[CDC::Chord](#cdc__chord)|Draws a chord (a closed figure bounded by the intersection of an ellipse and a line segment).|  
|[CDC::CloseFigure](#cdc__closefigure)|Closes an open figure in a path.|  
|[CDC::CreateCompatibleDC](#cdc__createcompatibledc)|Creates a memory-device context that is compatible with another device context. You can use it to prepare images in memory.|  
|[CDC::CreateDC](#cdc__createdc)|Creates a device context for a specific device.|  
|[CDC::CreateIC](#cdc__createic)|Creates an information context for a specific device. This provides a fast way to get information about the device without creating a device context.|  
|[CDC::DeleteDC](#cdc__deletedc)|Deletes the Windows device context associated with this <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> object.|  
|[CDC::DeleteTempMap](#cdc__deletetempmap)|Called by the <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> idle-time handler to delete any temporary <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> object created by <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>. Also detaches the device context.|  
|[CDC::Detach](#cdc__detach)|Detaches the Windows device context from this <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> object.|  
|[CDC::DPtoHIMETRIC](#cdc__dptohimetric)|Converts device units into **HIMETRIC** units.|  
|[CDC::DPtoLP](#cdc__dptolp)|Converts device units into logical units.|  
|[CDC::Draw3dRect](#cdc__draw3drect)|Draws a three-dimensional rectangle.|  
|[CDC::DrawDragRect](#cdc__drawdragrect)|Erases and redraws a rectangle as it is dragged.|  
|[CDC::DrawEdge](#cdc__drawedge)|Draws the edges of a rectangle.|  
|[CDC::DrawEscape](#cdc__drawescape)|Accesses drawing capabilities of a video display that are not directly available through the graphics device interface (GDI).|  
|[CDC::DrawFocusRect](#cdc__drawfocusrect)|Draws a rectangle in the style used to indicate focus.|  
|[CDC::DrawFrameControl](#cdc__drawframecontrol)|Draw a frame control.|  
|[CDC::DrawIcon](#cdc__drawicon)|Draws an icon.|  
|[CDC::DrawState](#cdc__drawstate)|Displays an image and applies a visual effect to indicate a state.|  
|[CDC::DrawText](#cdc__drawtext)|Draws formatted text in the specified rectangle.|  
|[CDC::DrawTextEx](#cdc__drawtextex)|Draws formatted text in the specified rectangle using additional formats.|  
|[CDC::Ellipse](#cdc__ellipse)|Draws an ellipse.|  
|[CDC::EndDoc](#cdc__enddoc)|Ends a print job started by the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> member function.|  
|[CDC::EndPage](#cdc__endpage)|Informs the device driver that a page is ending.|  
|[CDC::EndPath](#cdc__endpath)|Closes a path bracket and selects the path defined by the bracket into the device context.|  
|[CDC::EnumObjects](#cdc__enumobjects)|Enumerates the pens and brushes available in a device context.|  
|[CDC::Escape](#cdc__escape)|Allows applications to access facilities that are not directly available from a particular device through GDI. Also allows access to Windows escape functions. Escape calls made by an application are translated and sent to the device driver.|  
|[CDC::ExcludeClipRect](#cdc__excludecliprect)|Creates a new clipping region that consists of the existing clipping region minus the specified rectangle.|  
|[CDC::ExcludeUpdateRgn](#cdc__excludeupdatergn)|Prevents drawing within invalid areas of a window by excluding an updated region in the window from a clipping region.|  
|[CDC::ExtFloodFill](#cdc__extfloodfill)|Fills an area with the current brush. Provides more flexibility than the [FloodFill](#cdc__floodfill) member function.|  
|[CDC::ExtTextOut](#cdc__exttextout)|Writes a character string within a rectangular region using the currently selected font.|  
|[CDC::FillPath](#cdc__fillpath)|Closes any open figures in the current path and fills the path's interior by using the current brush and polygon-filling mode.|  
|[CDC::FillRect](#cdc__fillrect)|Fills a given rectangle by using a specific brush.|  
|[CDC::FillRgn](#cdc__fillrgn)|Fills a specific region with the specified brush.|  
|[CDC::FillSolidRect](#cdc__fillsolidrect)|Fills a rectangle with a solid color.|  
|[CDC::FlattenPath](#cdc__flattenpath)|Transforms any curves in the path selected into the current device context, and turns each curve into a sequence of lines.|  
|[CDC::FloodFill](#cdc__floodfill)|Fills an area with the current brush.|  
|[CDC::FrameRect](#cdc__framerect)|Draws a border around a rectangle.|  
|[CDC::FrameRgn](#cdc__framergn)|Draws a border around a specific region using a brush.|  
|[CDC::FromHandle](#cdc__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> object when given a handle to a device context. If a <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> object is not attached to the handle, a temporary <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> object is created and attached.|  
|[CDC::GetArcDirection](#cdc__getarcdirection)|Returns the current arc direction for the device context.|  
|[CDC::GetAspectRatioFilter](#cdc__getaspectratiofilter)|Retrieves the setting for the current aspect-ratio filter.|  
|[CDC::GetBkColor](#cdc__getbkcolor)|Retrieves the current background color.|  
|[CDC::GetBkMode](#cdc__getbkmode)|Retrieves the background mode.|  
|[CDC::GetBoundsRect](#cdc__getboundsrect)|Returns the current accumulated bounding rectangle for the specified device context.|  
|[CDC::GetBrushOrg](#cdc__getbrushorg)|Retrieves the origin of the current brush.|  
|[CDC::GetCharABCWidths](#cdc__getcharabcwidths)|Retrieves the widths, in logical units, of consecutive characters in a given range from the current font.|  
|[CDC::GetCharABCWidthsI](#cdc__getcharabcwidthsi)|Retrieves the widths, in logical units, of consecutive glyph indices in a specified range from the current TrueType font.|  
|[CDC::GetCharacterPlacement](#cdc__getcharacterplacement)|Retrieves various types of information on a character string.|  
|[CDC::GetCharWidth](#cdc__getcharwidth)|Retrieves the fractional widths of consecutive characters in a given range from the current font.|  
|[CDC::GetCharWidthI](#cdc__getcharwidthi)|Retrieves the widths, in logical coordinates, of consecutive glyph indices in a specified range from the current font.|  
|[CDC::GetClipBox](#cdc__getclipbox)|Retrieves the dimensions of the tightest bounding rectangle around the current clipping boundary.|  
|[CDC::GetColorAdjustment](#cdc__getcoloradjustment)|Retrieves the color adjustment values for the device context.|  
|[CDC::GetCurrentBitmap](#cdc__getcurrentbitmap)|Returns a pointer to the currently selected <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> object.|  
|[CDC::GetCurrentBrush](#cdc__getcurrentbrush)|Returns a pointer to the currently selected <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> object.|  
|[CDC::GetCurrentFont](#cdc__getcurrentfont)|Returns a pointer to the currently selected <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> object.|  
|[CDC::GetCurrentPalette](#cdc__getcurrentpalette)|Returns a pointer to the currently selected <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> object.|  
|[CDC::GetCurrentPen](#cdc__getcurrentpen)|Returns a pointer to the currently selected <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> object.|  
|[CDC::GetCurrentPosition](#cdc__getcurrentposition)|Retrieves the current position of the pen (in logical coordinates).|  
|[CDC::GetDCBrushColor](#cdc__getdcbrushcolor)|Retrieves the current brush color.|  
|[CDC::GetDCPenColor](#cdc__getdcpencolor)|Retrieves the current pen color.|  
|[CDC::GetDeviceCaps](#cdc__getdevicecaps)|Retrieves a specified kind of device-specific information about a given display device's capabilities.|  
|[CDC::GetFontData](#cdc__getfontdata)|Retrieves font metric information from a scalable font file. The information to retrieve is identified by specifying an offset into the font file and the length of the information to return.|  
|[CDC::GetFontLanguageInfo](#cdc__getfontlanguageinfo)|Returns information about the currently selected font for the specified display context.|  
|[CDC::GetGlyphOutline](#cdc__getglyphoutline)|Retrieves the outline curve or bitmap for an outline character in the current font.|  
|[CDC::GetGraphicsMode](#cdc__getgraphicsmode)|Retrieves the current graphics mode for the specified device context.|  
|[CDC::GetHalftoneBrush](#cdc__gethalftonebrush)|Retrieves a halftone brush.|  
|[CDC::GetKerningPairs](#cdc__getkerningpairs)|Retrieves the character kerning pairs for the font that is currently selected in the specified device context.|  
|[CDC::GetLayout](#cdc__getlayout)|Retrieves the layout of a device context (DC). The layout can be either left to right (default) or right to left (mirrored).|  
|[CDC::GetMapMode](#cdc__getmapmode)|Retrieves the current mapping mode.|  
|[CDC::GetMiterLimit](#cdc__getmiterlimit)|Returns the miter limit for the device context.|  
|[CDC::GetNearestColor](#cdc__getnearestcolor)|Retrieves the closest logical color to a specified logical color that the given device can represent.|  
|[CDC::GetOutlineTextMetrics](#cdc__getoutlinetextmetrics)|Retrieves font metric information for TrueType fonts.|  
|[CDC::GetOutputCharWidth](#cdc__getoutputcharwidth)|Retrieves the widths of individual characters in a consecutive group of characters from the current font using the output device context.|  
|[CDC::GetOutputTabbedTextExtent](#cdc__getoutputtabbedtextextent)|Computes the width and height of a character string on the output device context.|  
|[CDC::GetOutputTextExtent](#cdc__getoutputtextextent)|Computes the width and height of a line of text on the output device context using the current font to determine the dimensions.|  
|[CDC::GetOutputTextMetrics](#cdc__getoutputtextmetrics)|Retrieves the metrics for the current font from the output device context.|  
|[CDC::GetPath](#cdc__getpath)|Retrieves the coordinates defining the endpoints of lines and the control points of curves found in the path that is selected into the device context.|  
|[CDC::GetPixel](#cdc__getpixel)|Retrieves the RGB color value of the pixel at the specified point.|  
|[CDC::GetPolyFillMode](#cdc__getpolyfillmode)|Retrieves the current polygon-filling mode.|  
|[CDC::GetROP2](#cdc__getrop2)|Retrieves the current drawing mode.|  
|[CDC::GetSafeHdc](#cdc__getsafehdc)|Returns [m_hDC](#cdc__m_hdc), the output device context.|  
|[CDC::GetStretchBltMode](#cdc__getstretchbltmode)|Retrieves the current bitmap-stretching mode.|  
|[CDC::GetTabbedTextExtent](#cdc__gettabbedtextextent)|Computes the width and height of a character string on the attribute device context.|  
|[CDC::GetTextAlign](#cdc__gettextalign)|Retrieves the text-alignment flags.|  
|[CDC::GetTextCharacterExtra](#cdc__gettextcharacterextra)|Retrieves the current setting for the amount of intercharacter spacing.|  
|[CDC::GetTextColor](#cdc__gettextcolor)|Retrieves the current text color.|  
|[CDC::GetTextExtent](#cdc__gettextextent)|Computes the width and height of a line of text on the attribute device context using the current font to determine the dimensions.|  
|[CDC::GetTextExtentExPointI](#cdc__gettextextentexpointi)|Retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters.|  
|[CDC::GetTextExtentPointI](#cdc__gettextextentpointi)|Retrieves the width and height of the specified array of glyph indices.|  
|[CDC::GetTextFace](#cdc__gettextface)|Copies the typeface name of the current font into a buffer as a null-terminated string.|  
|[CDC::GetTextMetrics](#cdc__gettextmetrics)|Retrieves the metrics for the current font from the attribute device context.|  
|[CDC::GetViewportExt](#cdc__getviewportext)|Retrieves the x- and y-extents of the viewport.|  
|[CDC::GetViewportOrg](#cdc__getviewportorg)|Retrieves the x- and y-coordinates of the viewport origin.|  
|[CDC::GetWindow](#cdc__getwindow)|Returns the window associated with the display device context.|  
|[CDC::GetWindowExt](#cdc__getwindowext)|Retrieves the x- and y-extents of the associated window.|  
|[CDC::GetWindowOrg](#cdc__getwindoworg)|Retrieves the x- and y-coordinates of the origin of the associated window.|  
|[CDC::GetWorldTransform](#cdc__getworldtransform)|Retrieves the current world-space to page-space transformation.|  
|[CDC::GradientFill](#cdc__gradientfill)|Fills rectangle and triangle structures with a gradating color.|  
|[CDC::GrayString](#cdc__graystring)|Draws dimmed (grayed) text at the given location.|  
|[CDC::HIMETRICtoDP](#cdc__himetrictodp)|Converts **HIMETRIC** units into device units.|  
|[CDC::HIMETRICtoLP](#cdc__himetrictolp)|Converts **HIMETRIC** units into logical units.|  
|[CDC::IntersectClipRect](#cdc__intersectcliprect)|Creates a new clipping region by forming the intersection of the current region and a rectangle.|  
|[CDC::InvertRect](#cdc__invertrect)|Inverts the contents of a rectangle.|  
|[CDC::InvertRgn](#cdc__invertrgn)|Inverts the colors in a region.|  
|[CDC::IsPrinting](#cdc__isprinting)|Determines whether the device context is being used for printing.|  
|[CDC::LineTo](#cdc__lineto)|Draws a line from the current position up to, but not including, a point.|  
|[CDC::LPtoDP](#cdc__lptodp)|Converts logical units into device units.|  
|[CDC::LPtoHIMETRIC](#cdc__lptohimetric)|Converts logical units into **HIMETRIC** units.|  
|[CDC::MaskBlt](#cdc__maskblt)|Combines the color data for the source and destination bitmaps using the given mask and raster operation.|  
|[CDC::ModifyWorldTransform](#cdc__modifyworldtransform)|Changes the world transformation for a device context using the specified mode.|  
|[CDC::MoveTo](#cdc__moveto)|Moves the current position.|  
|[CDC::OffsetClipRgn](#cdc__offsetcliprgn)|Moves the clipping region of the given device.|  
|[CDC::OffsetViewportOrg](#cdc__offsetviewportorg)|Modifies the viewport origin relative to the coordinates of the current viewport origin.|  
|[CDC::OffsetWindowOrg](#cdc__offsetwindoworg)|Modifies the window origin relative to the coordinates of the current window origin.|  
|[CDC::PaintRgn](#cdc__paintrgn)|Fills a region with the selected brush.|  
|[CDC::PatBlt](#cdc__patblt)|Creates a bit pattern.|  
|[CDC::Pie](#cdc__pie)|Draws a pie-shaped wedge.|  
|[CDC::PlayMetaFile](#cdc__playmetafile)|Plays the contents of the specified metafile on the given device. The enhanced version of <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> displays the picture stored in the given enhanced-format metafile. The metafile can be played any number of times.|  
|[CDC::PlgBlt](#cdc__plgblt)|Performs a bit-block transfer of the bits of color data from the specified rectangle in the source device context to the specified parallelogram in the given device context.|  
|[CDC::PolyBezier](#cdc__polybezier)|Draws one or more Bzier splines. The current position is neither used nor updated.|  
|[CDC::PolyBezierTo](#cdc__polybezierto)|Draws one or more Bzier splines, and moves the current position to the ending point of the last Bzier spline.|  
|[CDC::PolyDraw](#cdc__polydraw)|Draws a set of line segments and Bzier splines. This function updates the current position.|  
|[CDC::Polygon](#cdc__polygon)|Draws a polygon consisting of two or more points (vertices) connected by lines.|  
|[CDC::Polyline](#cdc__polyline)|Draws a set of line segments connecting the specified points.|  
|[CDC::PolylineTo](#cdc__polylineto)|Draws one or more straight lines and moves the current position to the ending point of the last line.|  
|[CDC::PolyPolygon](#cdc__polypolygon)|Creates two or more polygons that are filled using the current polygon-filling mode. The polygons may be disjoint or they may overlap.|  
|[CDC::PolyPolyline](#cdc__polypolyline)|Draws multiple series of connected line segments. The current position is neither used nor updated by this function.|  
|[CDC::PtVisible](#cdc__ptvisible)|Specifies whether the given point is within the clipping region.|  
|[CDC::RealizePalette](#cdc__realizepalette)|Maps palette entries in the current logical palette to the system palette.|  
|[CDC::Rectangle](#cdc__rectangle)|Draws a rectangle using the current pen and fills it using the current brush.|  
|[CDC::RectVisible](#cdc__rectvisible)|Determines whether any part of the given rectangle lies within the clipping region.|  
|[CDC::ReleaseAttribDC](#cdc__releaseattribdc)|Releases <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>, the attribute device context.|  
|[CDC::ReleaseOutputDC](#cdc__releaseoutputdc)|Releases <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, the output device context.|  
|[CDC::ResetDC](#cdc__resetdc)|Updates the <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> device context.|  
|[CDC::RestoreDC](#cdc__restoredc)|Restores the device context to a previous state saved with <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>.|  
|[CDC::RoundRect](#cdc__roundrect)|Draws a rectangle with rounded corners using the current pen and filled using the current brush.|  
|[CDC::SaveDC](#cdc__savedc)|Saves the current state of the device context.|  
|[CDC::ScaleViewportExt](#cdc__scaleviewportext)|Modifies the viewport extent relative to the current values.|  
|[CDC::ScaleWindowExt](#cdc__scalewindowext)|Modifies the window extents relative to the current values.|  
|[CDC::ScrollDC](#cdc__scrolldc)|Scrolls a rectangle of bits horizontally and vertically.|  
|[CDC::SelectClipPath](#cdc__selectclippath)|Selects the current path as a clipping region for the device context, combining the new region with any existing clipping region by using the specified mode.|  
|[CDC::SelectClipRgn](#cdc__selectcliprgn)|Combines the given region with the current clipping region by using the specified mode.|  
|[CDC::SelectObject](#cdc__selectobject)|Selects a GDI drawing object such as a pen.|  
|[CDC::SelectPalette](#cdc__selectpalette)|Selects the logical palette.|  
|[CDC::SelectStockObject](#cdc__selectstockobject)|Selects one of the predefined stock pens, brushes, or fonts provided by Windows.|  
|[CDC::SetAbortProc](#cdc__setabortproc)|Sets a programmer-supplied callback function that Windows calls if a print job must be aborted.|  
|[CDC::SetArcDirection](#cdc__setarcdirection)|Sets the drawing direction to be used for arc and rectangle functions.|  
|[CDC::SetAttribDC](#cdc__setattribdc)|Sets <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>, the attribute device context.|  
|[CDC::SetBkColor](#cdc__setbkcolor)|Sets the current background color.|  
|[CDC::SetBkMode](#cdc__setbkmode)|Sets the background mode.|  
|[CDC::SetBoundsRect](#cdc__setboundsrect)|Controls the accumulation of bounding-rectangle information for the specified device context.|  
|[CDC::SetBrushOrg](#cdc__setbrushorg)|Specifies the origin for the next brush selected into a device context.|  
|[CDC::SetColorAdjustment](#cdc__setcoloradjustment)|Sets the color adjustment values for the device context using the specified values.|  
|[CDC::SetDCBrushColor](#cdc__setdcbrushcolor)|Sets the current brush color.|  
|[CDC::SetDCPenColor](#cdc__setdcpencolor)|Sets the current pen color.|  
|[CDC::SetGraphicsMode](#cdc__setgraphicsmode)|Sets the current graphics mode for the specified device context.|  
|[CDC::SetLayout](#cdc__setlayout)|Changes the layout of a device context (DC).|  
|[CDC::SetMapMode](#cdc__setmapmode)|Sets the current mapping mode.|  
|[CDC::SetMapperFlags](#cdc__setmapperflags)|Alters the algorithm that the font mapper uses when it maps logical fonts to physical fonts.|  
|[CDC::SetMiterLimit](#cdc__setmiterlimit)|Sets the limit for the length of miter joins for the device context.|  
|[CDC::SetOutputDC](#cdc__setoutputdc)|Sets <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, the output device context.|  
|[CDC::SetPixel](#cdc__setpixel)|Sets the pixel at the specified point to the closest approximation of the specified color.|  
|[CDC::SetPixelV](#cdc__setpixelv)|Sets the pixel at the specified coordinates to the closest approximation of the specified color. <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> is faster than <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> because it does not need to return the color value of the point actually painted.|  
|[CDC::SetPolyFillMode](#cdc__setpolyfillmode)|Sets the polygon-filling mode.|  
|[CDC::SetROP2](#cdc__setrop2)|Sets the current drawing mode.|  
|[CDC::SetStretchBltMode](#cdc__setstretchbltmode)|Sets the bitmap-stretching mode.|  
|[CDC::SetTextAlign](#cdc__settextalign)|Sets the text-alignment flags.|  
|[CDC::SetTextCharacterExtra](#cdc__settextcharacterextra)|Sets the amount of intercharacter spacing.|  
|[CDC::SetTextColor](#cdc__settextcolor)|Sets the text color.|  
|[CDC::SetTextJustification](#cdc__settextjustification)|Adds space to the break characters in a string.|  
|[CDC::SetViewportExt](#cdc__setviewportext)|Sets the x- and y-extents of the viewport.|  
|[CDC::SetViewportOrg](#cdc__setviewportorg)|Sets the viewport origin.|  
|[CDC::SetWindowExt](#cdc__setwindowext)|Sets the x- and y-extents of the associated window.|  
|[CDC::SetWindowOrg](#cdc__setwindoworg)|Sets the window origin of the device context.|  
|[CDC::SetWorldTransform](#cdc__setworldtransform)|Sets the current world-space to page-space transformation.|  
|[CDC::StartDoc](#cdc__startdoc)|Informs the device driver that a new print job is starting.|  
|[CDC::StartPage](#cdc__startpage)|Informs the device driver that a new page is starting.|  
|[CDC::StretchBlt](#cdc__stretchblt)|Moves a bitmap from a source rectangle and device into a destination rectangle, stretching or compressing the bitmap if necessary to fit the dimensions of the destination rectangle.|  
|[CDC::StrokeAndFillPath](#cdc__strokeandfillpath)|Closes any open figures in a path, strikes the outline of the path by using the current pen, and fills its interior by using the current brush.|  
|[CDC::StrokePath](#cdc__strokepath)|Renders the specified path by using the current pen.|  
|[CDC::TabbedTextOut](#cdc__tabbedtextout)|Writes a character string at a specified location, expanding tabs to the values specified in an array of tab-stop positions.|  
|[CDC::TextOut](#cdc__textout)|Writes a character string at a specified location using the currently selected font.|  
|[CDC::TransparentBlt](#cdc__transparentblt)|Transfers a bit-block of color data from the specified source device context into a destination device context, rendering a specified color transparent in the transfer.|  
|[CDC::UpdateColors](#cdc__updatecolors)|Updates the client area of the device context by matching the current colors in the client area to the system palette on a pixel-by-pixel basis.|  
|[CDC::WidenPath](#cdc__widenpath)|Redefines the current path as the area that would be painted if the path were stroked using the pen currently selected into the device context.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CDC::operator HDC](#cdc__operator_hdc)|Retrieves the handle of the device context.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDC::m_hAttribDC](#cdc__m_hattribdc)|The attribute-device context used by this <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> object.|  
|[CDC::m_hDC](#cdc__m_hdc)|The output-device context used by this <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 The <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> object provides member functions for working with a device context, such as a display or printer, as well as members for working with a display context associated with the client area of a window.  
  
 Do all drawing through the member functions of a <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> object. The class provides member functions for device-context operations, working with drawing tools, type-safe graphics device interface (GDI) object selection, and working with colors and palettes. It also provides member functions for getting and setting drawing attributes, mapping, working with the viewport, working with the window extent, converting coordinates, working with regions, clipping, drawing lines, and drawing simple shapes, ellipses, and polygons. Member functions are also provided for drawing text, working with fonts, using printer escapes, scrolling, and playing metafiles.  
  
 To use a <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> object, construct it, and then call its member functions that parallel Windows functions that use device contexts.  
  
> [!NOTE]
>  Under Windows 95/98, all screen coordinates are limited to 16 bits. Therefore, an <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> passed to a <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> member function must lie in the range –32768 to 32767.  
  
 For specific uses, the Microsoft Foundation Class Library provides several classes derived from <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> . <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> encapsulates calls to <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> manages a display context associated with a window's client area. <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> manages a display context associated with an entire window, including its frame and controls. <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> associates a device context with a metafile.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> provides two member functions, [GetLayout](#cdc__getlayout) and [SetLayout](#cdc__setlayout), for reversing the layout of a device context, which does not inherit its layout from a window. Such right-to-left orientation is necessary for applications written for cultures, such as Arabic or Hebrew, where the character layout is not the European standard.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> contains two device contexts, [m_hDC](#cdc__m_hdc) and [m_hAttribDC](#cdc__m_hattribdc), which, on creation of a <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> object, refer to the same device. <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> directs all output GDI calls to <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> and most attribute GDI calls to <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>. (An example of an attribute call is <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>, while <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> is an output call.)  
  
 For example, the framework uses these two device contexts to implement a <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> object that will send output to a metafile while reading attributes from a physical device. Print preview is implemented in the framework in a similar fashion. You can also use the two device contexts in a similar way in your application-specific code.  
  
 There are times when you may need text-metric information from both the <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> device contexts. The following pairs of functions provide this capability:  
  
|Uses m_hAttribDC|Uses m_hDC|  
|-----------------------|-----------------|  
|[GetTextExtent](#cdc__gettextextent)|[GetOutputTextExtent](#cdc__getoutputtextextent)|  
|[GetTabbedTextExtent](#cdc__gettabbedtextextent)|[GetOutputTabbedTextExtent](#cdc__getoutputtabbedtextextent)|  
|[GetTextMetrics](#cdc__gettextmetrics)|[GetOutputTextMetrics](#cdc__getoutputtextmetrics)|  
|[GetCharWidth](#cdc__getcharwidth)|[GetOutputCharWidth](#cdc__getoutputcharwidth)|  
  
 For more information on <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cdc__abortdoc">\</a>  CDC::AbortDoc  
 Terminates the current print job and erases everything the application has written to the device since the last call to the [StartDoc](#cdc__startdoc) member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A value greater than or equal to 0 if successful, or a negative value if an error has occurred. The following list shows common error values and their meanings:  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User terminated the job through the Print Manager.  
  
### Remarks  
 This member function replaces the <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> printer escape.  
  
 **AbortDoc** should be used to terminate the following:  
  
-   Printing operations that do not specify an abort function using [SetAbortProc](#cdc__setabortproc).  
  
-   Printing operations that have not yet reached their first **NEWFRAME** or **NEXTBAND** escape call.  
  
 If an application encounters a printing error or a canceled print operation, it must not attempt to terminate the operation by using either the [EndDoc](#cdc__enddoc) or **AbortDoc** member functions of class <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>. GDI automatically terminates the operation before returning the error value.  
  
 If the application displays a dialog box to allow the user to cancel the print operation, it must call **AbortDoc** before destroying the dialog box.  
  
 If Print Manager was used to start the print job, calling **AbortDoc** erases the entire spool job — the printer receives nothing. If Print Manager was not used to start the print job, the data may have been sent to the printer before **AbortDoc** was called. In this case, the printer driver would have reset the printer (when possible) and closed the print job.  
  
### Example  
  See the example for [CDC::StartDoc](#cdc__startdoc).  
  
##  \<a name="cdc__abortpath">\</a>  CDC::AbortPath  
 Closes and discards any paths in the device context.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 If there is an open path bracket in the device context, the path bracket is closed and the path is discarded. If there is a closed path in the device context, the path is discarded.  
  
##  \<a name="cdc__addmetafilecomment">\</a>  CDC::AddMetaFileComment  
 Copies the comment from a buffer into a specified enhanced-format metafile.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *nDataSize*  
 Specifies the length of the comment buffer, in bytes.  
  
 *pCommentData*  
 Points to the buffer that contains the comment.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 A comment may include any private information — for example, the source of the picture and the date it was created. A comment should begin with an application signature, followed by the data. Comments should not contain position-specific data. Position-specific data specifies the location of a record, and it should not be included because one metafile may be embedded within another metafile. This function can only be used with enhanced metafiles.  
  
##  \<a name="cdc__alphablend">\</a>  CDC::AlphaBlend  
 Call this member function to display bitmaps that have transparent or semitransparent pixels.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 A pointer to the source device context.  
  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the source rectangle.  
  
 *blend*  
 Specifies a                                 [BLENDFUNCTION](http://msdn.microsoft.com/library/windows/desktop/dd183393) structure.  
  
### Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
### Remarks  
 See                         [AlphaBlend](http://msdn.microsoft.com/library/windows/desktop/dd183351) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
##  \<a name="cdc__anglearc">\</a>  CDC::AngleArc  
 Draws a line segment and an arc.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the center of the circle.  
  
 *y*  
 Specifies the logical y-coordinate of the center of the circle.  
  
 *nRadius*  
 Specifies the radius of the circle in logical units. This value must be positive.  
  
 *fStartAngle*  
 Specifies the starting angle in degrees relative to the x-axis.  
  
 *fSweepAngle*  
 Specifies the sweep angle in degrees relative to the starting angle.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The line segment is drawn from the current position to the beginning of the arc. The arc is drawn along the perimeter of a circle with the given radius and center. The length of the arc is defined by the given start and sweep angles.  
  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> moves the current position to the ending point of the arc. The arc drawn by this function may appear to be elliptical, depending on the current transformation and mapping mode. Before drawing the arc, this function draws the line segment from the current position to the beginning of the arc. The arc is drawn by constructing an imaginary circle with the specified radius around the specified center point. The starting point of the arc is determined by measuring counterclockwise from the x-axis of the circle by the number of degrees in the start angle. The ending point is similarly located by measuring counterclockwise from the starting point by the number of degrees in the sweep angle.  
  
 If the sweep angle is greater than 360 degrees the arc is swept multiple times. This function draws lines by using the current pen. The figure is not filled.  
  
##  \<a name="cdc__arc">\</a>  CDC::Arc  
 Draws an elliptical arc.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either an <CodeContentPlaceHolder>275\</CodeContentPlaceHolder> or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's ending point (in logical units). This point does not have to lie exactly on the arc. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The arc drawn by using the function is a segment of the ellipse defined by the specified bounding rectangle.  
  
 The actual starting point of the arc is the point at which a ray drawn from the center of the bounding rectangle through the specified starting point intersects the ellipse. The actual ending point of the arc is the point at which a ray drawn from the center of the bounding rectangle through the specified ending point intersects the ellipse. The arc is drawn in a counterclockwise direction. Since an arc is not a closed figure, it is not filled. Both the width and height of the rectangle must be greater than 2 units and less than 32,767 units.  
  
### Example  
 [!code[NVC_MFCDocView#29](../vs140/codesnippet/CPP/cdc-class_1.cpp)]  
  
##  \<a name="cdc__arcto">\</a>  CDC::ArcTo  
 Draws an elliptical arc.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) data structure or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's starting point (in logical units). This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) data structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the arc's ending point (in logical units). This point does not have to lie exactly on the arc. You can pass either a **POINT** data structure or a <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This function is similar to <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>, except that the current position is updated. The points ( <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>) and ( <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>) specify the bounding rectangle. An ellipse formed by the given bounding rectangle defines the curve of the arc. The arc extends counterclockwise (the default arc direction) from the point where it intersects the radial line from the center of the bounding rectangle to (                        *x3*, <CodeContentPlaceHolder>295\</CodeContentPlaceHolder>). The arc ends where it intersects the radial line from the center of the bounding rectangle to ( <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>). If the starting point and ending point are the same, a complete ellipse is drawn.  
  
 A line is drawn from the current position to the starting point of the arc. If no error occurs, the current position is set to the ending point of the arc. The arc is drawn using the current pen; it is not filled.  
  
##  \<a name="cdc__attach">\</a>  CDC::Attach  
 Use this member function to attach an <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> to the <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 A Windows device context.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> is stored in both <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>, the output device context, and in <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>, the attribute device context.  
  
##  \<a name="cdc__beginpath">\</a>  CDC::BeginPath  
 Opens a path bracket in the device context.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 After a path bracket is open, an application can begin calling GDI drawing functions to define the points that lie in the path. An application can close an open path bracket by calling the <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> member function. When an application calls <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>, any previous paths are discarded.  
  
 See                         [BeginPath](http://msdn.microsoft.com/library/windows/desktop/dd183363) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of the drawing functions that define points in a path.  
  
### Example  
 [!code[NVC_MFCDocView#30](../vs140/codesnippet/CPP/cdc-class_2.cpp)]  
  
##  \<a name="cdc__bitblt">\</a>  CDC::BitBlt  
 Copies a bitmap from the source device context to this current device context.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> object that identifies the device context from which the bitmap will be copied. It must be **NULL** if                                 *dwRop* specifies a raster operation that does not include a source.  
  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the source bitmap.  
  
 *dwRop*  
 Specifies the raster operation to be performed. Raster-operation codes define how the GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. See                                 [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of the raster-operation codes for                                 *dwRop* and their descriptions  
  
 For a complete list of raster-operation codes, see                         [About Raster Operation Codes](http://msdn.microsoft.com/library/windows/desktop/dd162892) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The application can align the windows or client areas on byte boundaries to ensure that the <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> operations occur on byte-aligned rectangles. (Set the **CS_BYTEALIGNWINDOW** or **CS_BYTEALIGNCLIENT** flags when you register the window classes.)  
  
 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> operations on byte-aligned rectangles are considerably faster than <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> operations on rectangles that are not byte aligned. If you want to specify class styles such as byte-alignment for your own device context, you will have to register a window class rather than relying on the Microsoft Foundation classes to do it for you. Use the global function [AfxRegisterWndClass](../vs140/afxregisterwndclass.md).  
  
 GDI transforms <CodeContentPlaceHolder>315\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>, once by using the destination device context, and once by using the source device context. If the resulting extents do not match, GDI uses the Windows <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> function to compress or stretch the source bitmap as necessary.  
  
 If destination, source, and pattern bitmaps do not have the same color format, the <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> function converts the source and pattern bitmaps to match the destination. The foreground and background colors of the destination bitmap are used in the conversion.  
  
 When the <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> function converts a monochrome bitmap to color, it sets white bits (1) to the background color and black bits (0) to the foreground color. The foreground and background colors of the destination device context are used. To convert color to monochrome, <CodeContentPlaceHolder>320\</CodeContentPlaceHolder> sets pixels that match the background color to white and sets all other pixels to black. <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> uses the foreground and background colors of the color device context to convert from color to monochrome.  
  
 Note that not all device contexts support <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>. To check whether a given device context does support <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>, use the <CodeContentPlaceHolder>324\</CodeContentPlaceHolder> member function and specify the **RASTERCAPS** index.  
  
### Example  
  See the example for [CDC::CreateCompatibleDC](#cdc__createcompatibledc).  
  
##  \<a name="cdc__cdc">\</a>  CDC::CDC  
 Constructs a <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="cdc__chord">\</a>  CDC::Chord  
 Draws a chord (a closed figure bounded by the intersection of an ellipse and a line segment).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the chord's bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the point that defines the chord's starting point (in logical units).  
  
 <CodeContentPlaceHolder>330\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the chord's starting point (in logical units).  
  
 <CodeContentPlaceHolder>331\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the point that defines the chord's endpoint (in logical units).  
  
 <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the chord's starting point (in logical units). This point does not have to lie exactly on the chord. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>337\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the point that defines the chord's ending point (in logical units). This point does not have to lie exactly on the chord. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The ( <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>339\</CodeContentPlaceHolder>) and ( <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>) parameters specify the upper-left and lower-right corners, respectively, of a rectangle bounding the ellipse that is part of the chord. The (                        *x3*, <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>) and ( <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>) parameters specify the endpoints of a line that intersects the ellipse. The chord is drawn by using the selected pen and filled by using the selected brush.  
  
 The figure drawn by the <CodeContentPlaceHolder>345\</CodeContentPlaceHolder> function extends up to, but does not include the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>346\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>348\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>349\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#31](../vs140/codesnippet/CPP/cdc-class_3.cpp)]  
  
##  \<a name="cdc__closefigure">\</a>  CDC::CloseFigure  
 Closes an open figure in a path.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The function closes the figure by drawing a line from the current position to the first point of the figure (usually, the point specified by the most recent call to the <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> member function) and connects the lines by using the line join style. If a figure is closed by using the <CodeContentPlaceHolder>351\</CodeContentPlaceHolder> member function instead of <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>, end caps are used to create the corner instead of a join. <CodeContentPlaceHolder>353\</CodeContentPlaceHolder> should only be called if there is an open path bracket in the device context.  
  
 A figure in a path is open unless it is explicitly closed by using this function. (A figure can be open even if the current point and the starting point of the figure are the same.) Any line or curve added to the path after <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> starts a new figure.  
  
##  \<a name="cdc__createcompatibledc">\</a>  CDC::CreateCompatibleDC  
 Creates a memory device context that is compatible with the device specified by <CodeContentPlaceHolder>355\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>356\</CodeContentPlaceHolder>  
 A pointer to a device context. If <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> is **NULL**, the function creates a memory device context that is compatible with the system display.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 A memory device context is a block of memory that represents a display surface. It can be used to prepare images in memory before copying them to the actual device surface of the compatible device.  
  
 When a memory device context is created, GDI automatically selects a 1-by-1 monochrome stock bitmap for it. GDI output functions can be used with a memory device context only if a bitmap has been created and selected into that context.  
  
 This function can only be used to create compatible device contexts for devices that support raster operations. See the [CDC::BitBlt](#cdc__bitblt) member function for information regarding bit-block transfers between device contexts. To determine whether a device context supports raster operations, see the **RC_BITBLT** raster capability in the member function <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#32](../vs140/codesnippet/CPP/cdc-class_4.cpp)]  
  
##  \<a name="cdc__createdc">\</a>  CDC::CreateDC  
 Creates a device context for the specified device.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the filename (without extension) of the device driver (for example, "EPSON"). You can also pass a <CodeContentPlaceHolder>360\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the name of the specific device to be supported (for example, "EPSON FX-80"). The <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> parameter is used if the module supports more than one device. You can also pass a <CodeContentPlaceHolder>363\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the file or device name for the physical output medium (file or output port). You can also pass a <CodeContentPlaceHolder>365\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> structure containing device-specific initialization data for the device driver. The Windows **DocumentProperties** function retrieves this structure filled in for a given device. The <CodeContentPlaceHolder>368\</CodeContentPlaceHolder> parameter must be **NULL** if the device driver is to use the default initialization (if any) specified by the user through the Control Panel.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The PRINT.H header file is required if the                         [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) structure is used.  
  
 Device names follow these conventions: an ending colon (:) is recommended, but optional. Windows strips the terminating colon so that a device name ending with a colon is mapped to the same port as the same name without a colon. The driver and port names must not contain leading or trailing spaces. GDI output functions cannot be used with information contexts.  
  
##  \<a name="cdc__createic">\</a>  CDC::CreateIC  
 Creates an information context for the specified device.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the filename (without extension) of the device driver (for example, "EPSON"). You can pass a <CodeContentPlaceHolder>370\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the name of the specific device to be supported (for example, "EPSON FX-80"). The <CodeContentPlaceHolder>372\</CodeContentPlaceHolder> parameter is used if the module supports more than one device. You can pass a <CodeContentPlaceHolder>373\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the file or device name for the physical output medium (file or port). You can pass a <CodeContentPlaceHolder>375\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 Points to device-specific initialization data for the device driver. The <CodeContentPlaceHolder>377\</CodeContentPlaceHolder> parameter must be **NULL** if the device driver is to use the default initialization (if any) specified by the user through the Control Panel. See <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> for the data format for device-specific initialization.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The information context provides a fast way to get information about the device without creating a device context.  
  
 Device names follow these conventions: an ending colon (:) is recommended, but optional. Windows strips the terminating colon so that a device name ending with a colon is mapped to the same port as the same name without a colon. The driver and port names must not contain leading or trailing spaces. GDI output functions cannot be used with information contexts.  
  
##  \<a name="cdc__deletedc">\</a>  CDC::DeleteDC  
 In general, do not call this function; the destructor will do it for you.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function completed successfully; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>379\</CodeContentPlaceHolder> member function deletes the Windows device contexts that are associated with <CodeContentPlaceHolder>380\</CodeContentPlaceHolder> in the current <CodeContentPlaceHolder>381\</CodeContentPlaceHolder> object. If this <CodeContentPlaceHolder>382\</CodeContentPlaceHolder> object is the last active device context for a given device, the device is notified and all storage and system resources used by the device are released.  
  
 An application should not call <CodeContentPlaceHolder>383\</CodeContentPlaceHolder> if objects have been selected into the device context. Objects must first be selected out of the device context before it is deleted.  
  
 An application must not delete a device context whose handle was obtained by calling [CWnd::GetDC](../vs140/cwnd-class.md#cwnd__getdc). Instead, it must call [CWnd::ReleaseDC](../vs140/cwnd-class.md#cwnd__releasedc) to free the device context. The [CClientDC](../vs140/cclientdc-class.md) and [CWindowDC](../vs140/cwindowdc-class.md) classes are provided to wrap this functionality.  
  
 The <CodeContentPlaceHolder>384\</CodeContentPlaceHolder> function is generally used to delete device contexts created with [CreateDC](#cdc__createdc), [CreateIC](#cdc__createic), or [CreateCompatibleDC](#cdc__createcompatibledc).  
  
### Example  
  See the example for [CPrintDialog::GetPrinterDC](../vs140/cprintdialog-class.md#cprintdialog__getprinterdc).  
  
##  \<a name="cdc__deletetempmap">\</a>  CDC::DeleteTempMap  
 Called automatically by the <CodeContentPlaceHolder>385\</CodeContentPlaceHolder> idle-time handler, <CodeContentPlaceHolder>386\</CodeContentPlaceHolder> deletes any temporary <CodeContentPlaceHolder>387\</CodeContentPlaceHolder> objects created by <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>, but does not destroy the device context handles ( <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>s) temporarily associated with the <CodeContentPlaceHolder>390\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="cdc__detach">\</a>  CDC::Detach  
 Call this function to detach <CodeContentPlaceHolder>391\</CodeContentPlaceHolder> (the output device context) from the <CodeContentPlaceHolder>392\</CodeContentPlaceHolder> object and set both <CodeContentPlaceHolder>393\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>394\</CodeContentPlaceHolder> to **NULL**.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 A Windows device context.  
  
##  \<a name="cdc__dptohimetric">\</a>  CDC::DPtoHIMETRIC  
 Use this function when you give **HIMETRIC** sizes to OLE, converting pixels to **HIMETRIC**.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>  
 Points to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 If the mapping mode of the device context object is <CodeContentPlaceHolder>396\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>399\</CodeContentPlaceHolder>, then the conversion is based on the number of pixels in the physical inch. If the mapping mode is one of the other non-constrained modes (e.g., <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>), then the conversion is based on the number of pixels in the logical inch.  
  
##  \<a name="cdc__dptolp">\</a>  CDC::DPtoLP  
 Converts device units into logical units.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>401\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) structures or [CPoint](../vs140/cpoint-class.md) objects.  
  
 <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
 The number of points in the array.  
  
 <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object. This parameter is used for the simple case of converting one rectangle from device points to logical points.  
  
 <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
 Points to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 The function maps the coordinates of each point, or dimension of a size, from the device coordinate system into GDI's logical coordinate system. The conversion depends on the current mapping mode and the settings of the origins and extents for the device's window and viewport.  
  
##  \<a name="cdc__draw3drect">\</a>  CDC::Draw3dRect  
 Call this member function to draw a three-dimensional rectangle.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 *clrTopLeft*  
 Specifies the color of the top and left sides of the three-dimensional rectangle.  
  
 <CodeContentPlaceHolder>406\</CodeContentPlaceHolder>  
 Specifies the color of the bottom and right sides of the three-dimensional rectangle.  
  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the three-dimensional rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the three-dimensional rectangle.  
  
 cx  
 Specifies the width of the three-dimensional rectangle.  
  
 cy  
 Specifies the height of the three-dimensional rectangle.  
  
### Remarks  
 The rectangle will be drawn with the top and left sides in the color specified by                         *clrTopLeft* and the bottom and right sides in the color specified by <CodeContentPlaceHolder>407\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#33](../vs140/codesnippet/CPP/cdc-class_5.cpp)]  
  
##  \<a name="cdc__drawdragrect">\</a>  CDC::DrawDragRect  
 Call this member function repeatedly to redraw a drag rectangle.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of a rectangle — in this case, the end position of the rectangle being redrawn.  
  
 <CodeContentPlaceHolder>409\</CodeContentPlaceHolder>  
 Specifies the displacement from the top-left corner of the outer border to the top-left corner of the inner border (that is, the thickness of the border) of a rectangle.  
  
 <CodeContentPlaceHolder>410\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of the position of a rectangle — in this case, the original position of the rectangle being redrawn.  
  
 *sizeLast*  
 Specifies the displacement from the top-left corner of the outer border to the top-left corner of the inner border (that is, the thickness of the border) of the original rectangle being redrawn.  
  
 <CodeContentPlaceHolder>411\</CodeContentPlaceHolder>  
 Pointer to a brush object. Set to **NULL** to use the default halftone brush.  
  
 *pBrushLast*  
 Pointer to the last brush object used. Set to **NULL** to use the default halftone brush.  
  
### Remarks  
 Call it in a loop as you sample mouse position, in order to give visual feedback. When you call <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>, the previous rectangle is erased and a new one is drawn. For example, as the user drags a rectangle across the screen, <CodeContentPlaceHolder>413\</CodeContentPlaceHolder> will erase the original rectangle and redraw a new one in its new position. By default, <CodeContentPlaceHolder>414\</CodeContentPlaceHolder> draws the rectangle by using a halftone brush to eliminate flicker and to create the appearance of a smoothly moving rectangle.  
  
 The first time you call <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>416\</CodeContentPlaceHolder> parameter should be **NULL**.  
  
##  \<a name="cdc__drawedge">\</a>  CDC::DrawEdge  
 Call this member function to draw the edges of a rectangle of the specified type and style.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>  
 A pointer to a **RECT** structure that contains the logical coordinates of the rectangle.  
  
 *nEdge*  
 Specifies the type of inner and outer edge to draw. This parameter must be a combination of one inner-border flag and one outer-border flag. See                                 [DrawEdge](http://msdn.microsoft.com/library/windows/desktop/dd162477) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a table of the parameter's types.  
  
 <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>  
 The flags that specify the type of border to be drawn. See <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a table of the parameter's values. For diagonal lines, the **BF_RECT** flags specify the end point of the vector bounded by the rectangle parameter.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cdc__drawescape">\</a>  CDC::DrawEscape  
 Accesses drawing capabilities of a video display that are not directly available through the graphics device interface (GDI).  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>  
 Specifies the escape function to be performed.  
  
 <CodeContentPlaceHolder>421\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>423\</CodeContentPlaceHolder>  
 Points to the input structure required for the specified escape.  
  
### Return Value  
 Specifies the outcome of the function. Greater than zero if successful, except for the **QUERYESCSUPPORT** draw escape, which checks for implementation only; or zero if the escape is not implemented; or less than zero if an error occurred.  
  
### Remarks  
 When an application calls <CodeContentPlaceHolder>424\</CodeContentPlaceHolder>, the data identified by <CodeContentPlaceHolder>425\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>426\</CodeContentPlaceHolder> is passed directly to the specified display driver.  
  
##  \<a name="cdc__drawfocusrect">\</a>  CDC::DrawFocusRect  
 Draws a rectangle in the style used to indicate that the rectangle has the focus.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>427\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object that specifies the logical coordinates of the rectangle to be drawn.  
  
### Remarks  
 Since this is a Boolean XOR function, calling this function a second time with the same rectangle removes the rectangle from the display. The rectangle drawn by this function cannot be scrolled. To scroll an area containing a rectangle drawn by this function, first call <CodeContentPlaceHolder>428\</CodeContentPlaceHolder> to remove the rectangle from the display, then scroll the area, and then call <CodeContentPlaceHolder>429\</CodeContentPlaceHolder> again to draw the rectangle in the new position.  
  
> [!CAUTION]
>  <CodeContentPlaceHolder>430\</CodeContentPlaceHolder> works only in <CodeContentPlaceHolder>431\</CodeContentPlaceHolder> mode. In other modes, this function does not draw the focus rectangle correctly, but it does not return error values.  
  
##  \<a name="cdc__drawframecontrol">\</a>  CDC::DrawFrameControl  
 Call this member function to draw a frame control of the specified type and style.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>432\</CodeContentPlaceHolder>  
 A pointer to a **RECT** structure that contains the logical coordinates of the rectangle.  
  
 <CodeContentPlaceHolder>433\</CodeContentPlaceHolder>  
 Specifies the type of frame control to draw. See the                                 *uType* parameter in                                 [DrawFrameControl](http://msdn.microsoft.com/library/windows/desktop/dd162480) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of this parameter's possible values.  
  
 <CodeContentPlaceHolder>434\</CodeContentPlaceHolder>  
 Specifies the initial state of the frame control. Can be one or more of the values described for the                                 *uState* parameter in <CodeContentPlaceHolder>435\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. Use the <CodeContentPlaceHolder>436\</CodeContentPlaceHolder> value **DFCS_ADJUSTRECT** to adjust the bounding rectangle to exclude the surrounding edge of the push button.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 In several cases, <CodeContentPlaceHolder>437\</CodeContentPlaceHolder> depends on the <CodeContentPlaceHolder>438\</CodeContentPlaceHolder> parameter. The following list shows the relationship between the four <CodeContentPlaceHolder>439\</CodeContentPlaceHolder> values and <CodeContentPlaceHolder>440\</CodeContentPlaceHolder>:  
  
-   **DFC_BUTTON**  
  
    -   **DFCS_BUTTON3STATE** Three-state button  
  
    -   **DFCS_BUTTONCHECK** Check box  
  
    -   **DFCS_BUTTONPUSH** Push button  
  
    -   **DFCS_BUTTONRADIO** Radio button  
  
    -   **DFCS_BUTTONRADIOIMAGE** Image for radio button (nonsquare needs image)  
  
    -   **DFCS_BUTTONRADIOMASK** Mask for radio button (nonsquare needs mask)  
  
-   **DFC_CAPTION**  
  
    -   **DFCS_CAPTIONCLOSE** Close button  
  
    -   **DFCS_CAPTIONHELP** Help button  
  
    -   **DFCS_CAPTIONMAX** Maximize button  
  
    -   **DFCS_CAPTIONMIN** Minimize button  
  
    -   **DFCS_CAPTIONRESTORE** Restore button  
  
-   **DFC_MENU**  
  
    -   **DFCS_MENUARROW** Submenu arrow  
  
    -   **DFCS_MENUBULLET** Bullet  
  
    -   **DFCS_MENUCHECK** Check mark  
  
-   **DFC_SCROLL**  
  
    -   **DFCS_SCROLLCOMBOBOX** Combo box scroll bar  
  
    -   **DFCS_SCROLLDOWN** Down arrow of scroll bar  
  
    -   **DFCS_SCROLLLEFT** Left arrow of scroll bar  
  
    -   **DFCS_SCROLLRIGHT** Right arrow of scroll bar  
  
    -   **DFCS_SCROLLSIZEGRIP** Size grip in bottom-right corner of window  
  
    -   **DFCS_SCROLLUP** Up arrow of scroll bar  
  
### Example  
 This code draws the size gripper in the bottom-right corner of your window. It's appropriate for the <CodeContentPlaceHolder>441\</CodeContentPlaceHolder> handler of a dialog box, which has no styles and normally doesn't contain other controls (like a status bar) that may give it a size gripper.  
  
 [!code[NVC_MFCDocView#34](../vs140/codesnippet/CPP/cdc-class_6.cpp)]  
  
##  \<a name="cdc__drawicon">\</a>  CDC::DrawIcon  
 Draws an icon on the device represented by the current <CodeContentPlaceHolder>442\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the icon.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the icon.  
  
 <CodeContentPlaceHolder>443\</CodeContentPlaceHolder>  
 Identifies the handle of the icon to be drawn.  
  
 <CodeContentPlaceHolder>444\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the upper-left corner of the icon. You can pass a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
### Return Value  
 Nonzero if the function completed successfully; otherwise 0.  
  
### Remarks  
 The function places the icon's upper-left corner at the location specified by                         *x* and                         *y*. The location is subject to the current mapping mode of the device context.  
  
 The icon resource must have been previously loaded by using the functions <CodeContentPlaceHolder>445\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>446\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>447\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>448\</CodeContentPlaceHolder> mapping mode must be selected prior to using this function.  
  
### Example  
  See the example for [CWnd::IsIconic](../vs140/cwnd-class.md#cwnd__isiconic).  
  
##  \<a name="cdc__drawstate">\</a>  CDC::DrawState  
 Call this member function to display an image and apply a visual effect to indicate a state, such as a disabled or default state.  
  
> [!NOTE]
>  For all <CodeContentPlaceHolder>449\</CodeContentPlaceHolder> states except **DSS_NORMAL**, the image is converted to monochrome before the visual effect is applied.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>450\</CodeContentPlaceHolder>  
 Specifies the location of the image.  
  
 <CodeContentPlaceHolder>451\</CodeContentPlaceHolder>  
 Specifies the size of the image.  
  
 <CodeContentPlaceHolder>452\</CodeContentPlaceHolder>  
 A handle to a bitmap.  
  
 <CodeContentPlaceHolder>453\</CodeContentPlaceHolder>  
 Flags that specify the image type and state. See                                 [DrawState](http://msdn.microsoft.com/library/windows/desktop/dd162496) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for the possible <CodeContentPlaceHolder>454\</CodeContentPlaceHolder> types and states.  
  
 <CodeContentPlaceHolder>455\</CodeContentPlaceHolder>  
 A handle to a brush.  
  
 <CodeContentPlaceHolder>456\</CodeContentPlaceHolder>  
 A pointer to a CBitmap object.  
  
 <CodeContentPlaceHolder>457\</CodeContentPlaceHolder>  
 A pointer to a CBrush object.  
  
 <CodeContentPlaceHolder>458\</CodeContentPlaceHolder>  
 A handle to an icon.  
  
 <CodeContentPlaceHolder>459\</CodeContentPlaceHolder>  
 A pointer to text.  
  
 *bPrefixText*  
 Text that may contain an accelerator mnemonic. The <CodeContentPlaceHolder>460\</CodeContentPlaceHolder> parameter specifies the address of the string, and the <CodeContentPlaceHolder>461\</CodeContentPlaceHolder> parameter specifies the length. If <CodeContentPlaceHolder>462\</CodeContentPlaceHolder> is 0, the string is assumed to be null-terminated.  
  
 <CodeContentPlaceHolder>463\</CodeContentPlaceHolder>  
 Length of the text string pointed to by <CodeContentPlaceHolder>464\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>465\</CodeContentPlaceHolder> is 0, the string is assumed to be null-terminated.  
  
 *lpDrawProc*  
 A pointer to a callback function used to render an image. This parameter is required if the image type in <CodeContentPlaceHolder>466\</CodeContentPlaceHolder> is **DST_COMPLEX**. It is optional and can be **NULL** if the image type is **DST_TEXT**. For all other image types, this parameter is ignored. For more information about the callback function, see the                                 [DrawStateProc](http://msdn.microsoft.com/library/windows/desktop/dd162497) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>467\</CodeContentPlaceHolder>  
 Specifies information about the image. The meaning of this parameter depends on the image type.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cdc__drawtext">\</a>  CDC::DrawText  
 Call this member function to format text in the given rectangle. To specify additional formatting options, use [CDC::DrawTextEx](#cdc__drawtextex).  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>468\</CodeContentPlaceHolder>  
 Points to the string to be drawn. If <CodeContentPlaceHolder>469\</CodeContentPlaceHolder> is –1, the string must be null-terminated.  
  
 <CodeContentPlaceHolder>470\</CodeContentPlaceHolder>  
 Specifies the number of chars in the string. If <CodeContentPlaceHolder>471\</CodeContentPlaceHolder> is –1, then <CodeContentPlaceHolder>472\</CodeContentPlaceHolder> is assumed to be a long pointer to a null-terminated string and <CodeContentPlaceHolder>473\</CodeContentPlaceHolder> computes the character count automatically.  
  
 <CodeContentPlaceHolder>474\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the rectangle (in logical coordinates) in which the text is to be formatted.  
  
 <CodeContentPlaceHolder>475\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object that contains the specified characters to be drawn.  
  
 <CodeContentPlaceHolder>476\</CodeContentPlaceHolder>  
 Specifies the method of formatting the text. It can be any combination of the values described for the <CodeContentPlaceHolder>477\</CodeContentPlaceHolder> parameter in                                 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. (combine using the bitwise OR operator):  
  
> [!NOTE]
>  Some <CodeContentPlaceHolder>478\</CodeContentPlaceHolder> flag combinations can cause the passed string to be modified. Using **DT_MODIFYSTRING** with either **DT_END_ELLIPSIS** or **DT_PATH_ELLIPSIS** may cause the string to be modified, causing an assertion in the <CodeContentPlaceHolder>479\</CodeContentPlaceHolder> override. The values <CodeContentPlaceHolder>480\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>481\</CodeContentPlaceHolder>, **DT_INTERNAL**, <CodeContentPlaceHolder>482\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>483\</CodeContentPlaceHolder> cannot be used with the <CodeContentPlaceHolder>484\</CodeContentPlaceHolder> value.  
  
### Return Value  
 The height of the text if the function is successful.  
  
### Remarks  
 It formats text by expanding tabs into appropriate spaces, aligning text to the left, right, or center of the given rectangle, and breaking text into lines that fit within the given rectangle. The type of formatting is specified by <CodeContentPlaceHolder>485\</CodeContentPlaceHolder>.  
  
 This member function uses the device context's selected font, text color, and background color to draw the text. Unless the <CodeContentPlaceHolder>486\</CodeContentPlaceHolder> format is used, <CodeContentPlaceHolder>487\</CodeContentPlaceHolder> clips the text so that the text does not appear outside the given rectangle. All formatting is assumed to have multiple lines unless the <CodeContentPlaceHolder>488\</CodeContentPlaceHolder> format is given.  
  
 If the selected font is too large for the specified rectangle, the <CodeContentPlaceHolder>489\</CodeContentPlaceHolder> member function does not attempt to substitute a smaller font.  
  
 If the <CodeContentPlaceHolder>490\</CodeContentPlaceHolder> flag is specified, the rectangle specified by <CodeContentPlaceHolder>491\</CodeContentPlaceHolder> will be updated to reflect the width and height needed to draw the text.  
  
 If the **TA_UPDATECP** text-alignment flag has been set (see [CDC::SetTextAlign](#cdc__settextalign)), <CodeContentPlaceHolder>492\</CodeContentPlaceHolder> will display text starting at the current position, rather than at the left of the given rectangle. <CodeContentPlaceHolder>493\</CodeContentPlaceHolder> will not wrap text when the **TA_UPDATECP** flag has been set (that is, the <CodeContentPlaceHolder>494\</CodeContentPlaceHolder> flag will have no effect).  
  
 The text color may be set by [CDC::SetTextColor](#cdc__settextcolor).  
  
##  \<a name="cdc__drawtextex">\</a>  CDC::DrawTextEx  
 Formats text in the given rectangle.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>495\</CodeContentPlaceHolder>  
 Points to the string to be drawn. If <CodeContentPlaceHolder>496\</CodeContentPlaceHolder> is –1, the string must be null terminated.  
  
 <CodeContentPlaceHolder>497\</CodeContentPlaceHolder>  
 Specifies the number of chars in the string. If <CodeContentPlaceHolder>498\</CodeContentPlaceHolder> is –1, then <CodeContentPlaceHolder>499\</CodeContentPlaceHolder> is assumed to be a long pointer to a null-terminated string and <CodeContentPlaceHolder>500\</CodeContentPlaceHolder> computes the character count automatically.  
  
 <CodeContentPlaceHolder>501\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the rectangle (in logical coordinates) in which the text is to be formatted.  
  
 <CodeContentPlaceHolder>502\</CodeContentPlaceHolder>  
 A [CString](../vs140/cstringt-class.md) object that contains the specified characters to be drawn.  
  
 <CodeContentPlaceHolder>503\</CodeContentPlaceHolder>  
 Specifies the method of formatting the text. It can be any combination of the values described for the <CodeContentPlaceHolder>504\</CodeContentPlaceHolder> parameter in                                 [DrawText](http://msdn.microsoft.com/library/windows/desktop/dd162498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. (Combine using the bitwise <CodeContentPlaceHolder>505\</CodeContentPlaceHolder> operator):  
  
> [!NOTE]
>  Some <CodeContentPlaceHolder>506\</CodeContentPlaceHolder> flag combinations can cause the passed string to be modified. Using **DT_MODIFYSTRING** with either **DT_END_ELLIPSIS** or **DT_PATH_ELLIPSIS** may cause the string to be modified, causing an assertion in the <CodeContentPlaceHolder>507\</CodeContentPlaceHolder> override. The values <CodeContentPlaceHolder>508\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>509\</CodeContentPlaceHolder>, **DT_INTERNAL**, <CodeContentPlaceHolder>510\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>511\</CodeContentPlaceHolder> cannot be used with the <CodeContentPlaceHolder>512\</CodeContentPlaceHolder> value.  
  
 <CodeContentPlaceHolder>513\</CodeContentPlaceHolder>  
 Pointer to a                                 [DRAWTEXTPARAMS](http://msdn.microsoft.com/library/windows/desktop/dd162500) structure that specifies additional formatting options. This parameter can be **NULL**.  
  
### Remarks  
 It formats text by expanding tabs into appropriate spaces, aligning text to the left, right, or center of the given rectangle, and breaking text into lines that fit within the given rectangle. The type of formatting is specified by <CodeContentPlaceHolder>514\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>515\</CodeContentPlaceHolder>. For more information, see [CDC::DrawText](#cdc__drawtext) and                         [DrawTextEx](http://msdn.microsoft.com/library/windows/desktop/dd162499) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The text color may be set by [CDC::SetTextColor](#cdc__settextcolor).  
  
##  \<a name="cdc__ellipse">\</a>  CDC::Ellipse  
 Draws an ellipse.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>516\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>517\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>518\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>519\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the ellipse's bounding rectangle.  
  
 <CodeContentPlaceHolder>520\</CodeContentPlaceHolder>  
 Specifies the ellipse's bounding rectangle. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The center of the ellipse is the center of the bounding rectangle specified by <CodeContentPlaceHolder>521\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>522\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>523\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>524\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>525\</CodeContentPlaceHolder>. The ellipse is drawn with the current pen, and its interior is filled with the current brush.  
  
 The figure drawn by this function extends up to, but does not include, the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>526\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>527\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>528\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>529\</CodeContentPlaceHolder>.  
  
 If either the width or the height of the bounding rectangle is 0, no ellipse is drawn.  
  
##  \<a name="cdc__enddoc">\</a>  CDC::EndDoc  
 Ends a print job started by a call to the [StartDoc](#cdc__startdoc) member function.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
 Greater than or equal to 0 if the function is successful, or a negative value if an error occurred.  
  
### Remarks  
 This member function replaces the **ENDDOC** printer escape, and should be called immediately after finishing a successful print job.  
  
 If an application encounters a printing error or a canceled print operation, it must not attempt to terminate the operation by using either <CodeContentPlaceHolder>530\</CodeContentPlaceHolder> or [AbortDoc](#cdc__abortdoc). GDI automatically terminates the operation before returning the error value.  
  
 This function should not be used inside metafiles.  
  
### Example  
  See the example for [CDC::StartDoc](#cdc__startdoc).  
  
##  \<a name="cdc__endpage">\</a>  CDC::EndPage  
 Informs the device that the application has finished writing to a page.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 Greater than or equal to 0 if the function is successful, or a negative value if an error occurred.  
  
### Remarks  
 This member function is typically used to direct the device driver to advance to a new page.  
  
 This member function replaces the **NEWFRAME** printer escape. Unlike **NEWFRAME**, this function is always called after printing a page.  
  
### Example  
  See the example for [CDC::StartDoc](#cdc__startdoc).  
  
##  \<a name="cdc__endpath">\</a>  CDC::EndPath  
 Closes a path bracket and selects the path defined by the bracket into the device context.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Example  
  See the example for [CDC::BeginPath](#cdc__beginpath).  
  
##  \<a name="cdc__enumobjects">\</a>  CDC::EnumObjects  
 Enumerates the pens and brushes available in a device context.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 *nObjectType*  
 Specifies the object type. It can have the values **OBJ_BRUSH** or **OBJ_PEN**.  
  
 <CodeContentPlaceHolder>531\</CodeContentPlaceHolder>  
 Is the procedure-instance address of the application-supplied callback function. See the "Remarks" section below.  
  
 <CodeContentPlaceHolder>532\</CodeContentPlaceHolder>  
 Points to the application-supplied data. The data is passed to the callback function along with the object information.  
  
### Return Value  
 Specifies the last value returned by the [callback function](../vs140/callback-function-for-cdc--enumobjects.md). Its meaning is user-defined.  
  
### Remarks  
 For each object of a given type, the callback function that you pass is called with the information for that object. The system calls the callback function until there are no more objects or the callback function returns 0.  
  
 Note that new features of Microsoft Visual C++ let you use an ordinary function as the function passed to <CodeContentPlaceHolder>533\</CodeContentPlaceHolder>. The address passed to <CodeContentPlaceHolder>534\</CodeContentPlaceHolder> is a pointer to a function exported with **EXPORT** and with the Pascal calling convention. In protect-mode applications, you do not have to create this function with the Windows                         [MakeProcInstance](https://msdn.microsoft.com/en-us/library/aa383722.aspx) function or free the function after use with the                         [FreeProcInstance](https://msdn.microsoft.com/en-us/library/aa383722.aspx) Windows function.  
  
 You also do not have to export the function name in an **EXPORTS** statement in your application's module-definition file. You can instead use the **EXPORT** function modifier, as in  
  
 **int CALLBACK EXPORT** AFunction **(LPSTR**, **LPSTR);**  
  
 to cause the compiler to emit the proper export record for export by name without aliasing. This works for most needs. For some special cases, such as exporting a function by ordinal or aliasing the export, you still need to use an **EXPORTS** statement in a module-definition file.  
  
 For compiling Microsoft Foundation programs, you will normally use the /GA and /GEs compiler options. The /Gw compiler option is not used with the Microsoft Foundation classes. (If you do use the Windows function **MakeProcInstance**, you will need to explicitly cast the returned function pointer from **FARPROC** to the type needed in this API.) Callback registration interfaces are now type-safe (you must pass in a function pointer that points to the right kind of function for the specific callback).  
  
 Also note that all callback functions must trap Microsoft Foundation exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
### Example  
 [!code[NVC_MFCDocView#35](../vs140/codesnippet/CPP/cdc-class_7.cpp)]  
  
##  \<a name="cdc__escape">\</a>  CDC::Escape  
 This member function is practically obsolete for Win32 programming.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>535\</CodeContentPlaceHolder>  
 Specifies the escape function to be performed.  
  
 For a complete list of escape functions, see                                 [Escape](http://msdn.microsoft.com/library/windows/desktop/dd162701) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>536\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by <CodeContentPlaceHolder>537\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>538\</CodeContentPlaceHolder>  
 Points to the input data structure required for this escape.  
  
 <CodeContentPlaceHolder>539\</CodeContentPlaceHolder>  
 Points to the structure that is to receive output from this escape. The <CodeContentPlaceHolder>540\</CodeContentPlaceHolder> parameter is **NULL** if no data is returned.  
  
 <CodeContentPlaceHolder>541\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>542\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>543\</CodeContentPlaceHolder>  
 Points to the input structure required for the specified escape.  
  
 <CodeContentPlaceHolder>544\</CodeContentPlaceHolder>  
 Specifies the number of bytes of data pointed to by the <CodeContentPlaceHolder>545\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>546\</CodeContentPlaceHolder>  
 Points to the structure that receives output from this escape. This parameter should be **NULL** if no data is returned.  
  
### Return Value  
 A positive value is returned if the function is successful, except for the **QUERYESCSUPPORT** escape, which only checks for implementation. Zero is returned if the escape is not implemented. A negative value is returned if an error occurred. The following are common error values:  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User ended the job through the Print Manager.  
  
### Remarks  
 Of the original printer escapes, only **QUERYESCSUPPORT** is supported for Win32 applications. All other printer escapes are obsolete and are supported only for compatibility with 16-bit applications.  
  
 For Win32 programming, <CodeContentPlaceHolder>547\</CodeContentPlaceHolder> now provides six member functions that supersede their corresponding printer escapes:  
  
-   [CDC::AbortDoc](#cdc__abortdoc)  
  
-   [CDC::EndDoc](#cdc__enddoc)  
  
-   [CDC::EndPage](#cdc__endpage)  
  
-   [CDC::SetAbortProc](#cdc__setabortproc)  
  
-   [CDC::StartDoc](#cdc__startdoc)  
  
-   [CDC::StartPage](#cdc__startpage)  
  
 In addition, [CDC::GetDeviceCaps](#cdc__getdevicecaps) supports Win32 indexes that supersede other printer escapes. See                         [GetDeviceCaps](http://msdn.microsoft.com/library/windows/desktop/dd144877) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 This member function allows applications to access facilities of a particular device that are not directly available through GDI.  
  
 Use the first version if your application uses predefined escape values. Use the second version if your application defines private escape values. See                         [ExtEscape](http://msdn.microsoft.com/library/windows/desktop/dd162708) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about the second version.  
  
##  \<a name="cdc__excludecliprect">\</a>  CDC::ExcludeClipRect  
 Creates a new clipping region that consists of the existing clipping region minus the specified rectangle.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>548\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>549\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>550\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>551\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>552\</CodeContentPlaceHolder>  
 Specifies the rectangle. Can also be a <CodeContentPlaceHolder>553\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Specifies the new clipping region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** The region has overlapping borders.  
  
-   **ERROR** No region was created.  
  
-   **NULLREGION** The region is empty.  
  
-   **SIMPLEREGION** The region has no overlapping borders.  
  
### Remarks  
 The width of the rectangle, specified by the absolute value of <CodeContentPlaceHolder>554\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>555\</CodeContentPlaceHolder>, must not exceed 32,767 units. This limit applies to the height of the rectangle as well.  
  
##  \<a name="cdc__excludeupdatergn">\</a>  CDC::ExcludeUpdateRgn  
 Prevents drawing within invalid areas of a window by excluding an updated region in the window from the clipping region associated with the <CodeContentPlaceHolder>556\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>557\</CodeContentPlaceHolder>  
 Points to the window object whose window is being updated.  
  
### Return Value  
 The type of excluded region. It can be any one of the following values:  
  
-   **COMPLEXREGION** The region has overlapping borders.  
  
-   **ERROR** No region was created.  
  
-   **NULLREGION** The region is empty.  
  
-   **SIMPLEREGION** The region has no overlapping borders.  
  
##  \<a name="cdc__extfloodfill">\</a>  CDC::ExtFloodFill  
 Fills an area of the display surface with the current brush.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point where filling begins.  
  
 *y*  
 Specifies the logical y-coordinate of the point where filling begins.  
  
 <CodeContentPlaceHolder>558\</CodeContentPlaceHolder>  
 Specifies the color of the boundary or of the area to be filled. The interpretation of <CodeContentPlaceHolder>559\</CodeContentPlaceHolder> depends on the value of <CodeContentPlaceHolder>560\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>561\</CodeContentPlaceHolder>  
 Specifies the type of flood fill to be performed. It must be either of the following values:  
  
-   **FLOODFILLBORDER** The fill area is bounded by the color specified by <CodeContentPlaceHolder>562\</CodeContentPlaceHolder>. This style is identical to the filling performed by <CodeContentPlaceHolder>563\</CodeContentPlaceHolder>.  
  
-   **FLOODFILLSURFACE** The fill area is defined by the color specified by <CodeContentPlaceHolder>564\</CodeContentPlaceHolder>. Filling continues outward in all directions as long as the color is encountered. This style is useful for filling areas with multicolored boundaries.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0 if the filling could not be completed, if the given point has the boundary color specified by <CodeContentPlaceHolder>565\</CodeContentPlaceHolder> (if **FLOODFILLBORDER** was requested), if the given point does not have the color specified by <CodeContentPlaceHolder>566\</CodeContentPlaceHolder> (if **FLOODFILLSURFACE** was requested), or if the point is outside the clipping region.  
  
### Remarks  
 This member function offers more flexibility than <CodeContentPlaceHolder>567\</CodeContentPlaceHolder> because you can specify a fill type in <CodeContentPlaceHolder>568\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>569\</CodeContentPlaceHolder> is set to **FLOODFILLBORDER**, the area is assumed to be completely bounded by the color specified by <CodeContentPlaceHolder>570\</CodeContentPlaceHolder>. The function begins at the point specified by                         *x* and                         *y* and fills in all directions to the color boundary.  
  
 If <CodeContentPlaceHolder>571\</CodeContentPlaceHolder> is set to **FLOODFILLSURFACE**, the function begins at the point specified by                         *x* and                         *y* and continues in all directions, filling all adjacent areas containing the color specified by <CodeContentPlaceHolder>572\</CodeContentPlaceHolder>.  
  
 Only memory-device contexts and devices that support raster-display technology support <CodeContentPlaceHolder>573\</CodeContentPlaceHolder>. For more information, see the [GetDeviceCaps](#cdc__getdevicecaps) member function.  
  
##  \<a name="cdc__exttextout">\</a>  CDC::ExtTextOut  
 Call this member function to write a character string within a rectangular region using the currently selected font.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the character cell for the first character in the specified string.  
  
 *y*  
 Specifies the logical y-coordinate of the top of the character cell for the first character in the specified string.  
  
 <CodeContentPlaceHolder>574\</CodeContentPlaceHolder>  
 Specifies the rectangle type. This parameter can be one, both, or neither of the following values:  
  
-   **ETO_CLIPPED** Specifies that text is clipped to the rectangle.  
  
-   **ETO_OPAQUE** Specifies that the current background color fills the rectangle. (You can set and query the current background color with the [SetBkColor](#cdc__setbkcolor) and [GetBkColor](#cdc__getbkcolor) member functions.)  
  
 <CodeContentPlaceHolder>575\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure that determines the dimensions of the rectangle. This parameter can be **NULL**. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>576\</CodeContentPlaceHolder>  
 Points to the specified character string to be drawn. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>577\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string.  
  
 <CodeContentPlaceHolder>578\</CodeContentPlaceHolder>  
 Points to an array of values that indicate the distance between origins of adjacent character cells. For instance, <CodeContentPlaceHolder>579\</CodeContentPlaceHolder>[                                *i*] logical units will separate the origins of character cell                                 *i* and character cell                                 *i* + 1. If <CodeContentPlaceHolder>580\</CodeContentPlaceHolder> is **NULL**, <CodeContentPlaceHolder>581\</CodeContentPlaceHolder> uses the default spacing between characters.  
  
 <CodeContentPlaceHolder>582\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>583\</CodeContentPlaceHolder> object that contains the specified characters to be drawn.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The rectangular region can be opaque (filled with the current background color), and it can be a clipping region.  
  
 If <CodeContentPlaceHolder>584\</CodeContentPlaceHolder> is 0 and <CodeContentPlaceHolder>585\</CodeContentPlaceHolder> is **NULL**, the function writes text to the device context without using a rectangular region. By default, the current position is not used or updated by the function. If an application needs to update the current position when it calls <CodeContentPlaceHolder>586\</CodeContentPlaceHolder>, the application can call the <CodeContentPlaceHolder>587\</CodeContentPlaceHolder> member function [SetTextAlign](#cdc__settextalign) with <CodeContentPlaceHolder>588\</CodeContentPlaceHolder> set to **TA_UPDATECP**. When this flag is set, Windows ignores                         *x* and                         *y* on subsequent calls to <CodeContentPlaceHolder>589\</CodeContentPlaceHolder> and uses the current position instead. When an application uses **TA_UPDATECP** to update the current position, <CodeContentPlaceHolder>590\</CodeContentPlaceHolder> sets the current position either to the end of the previous line of text or to the position specified by the last element of the array pointed to by <CodeContentPlaceHolder>591\</CodeContentPlaceHolder>, whichever is greater.  
  
##  \<a name="cdc__fillpath">\</a>  CDC::FillPath  
 Closes any open figures in the current path and fills the path's interior by using the current brush and polygon-filling mode.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 After its interior is filled, the path is discarded from the device context.  
  
##  \<a name="cdc__fillrect">\</a>  CDC::FillRect  
 Call this member function to fill a given rectangle using the specified brush.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>592\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure that contains the logical coordinates of the rectangle to be filled. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>593\</CodeContentPlaceHolder>  
 Identifies the brush used to fill the rectangle.  
  
### Remarks  
 The function fills the complete rectangle, including the left and top borders, but it does not fill the right and bottom borders.  
  
 The brush needs to either be created using the [CBrush](../vs140/cbrush-class.md) member functions [CreateHatchBrush](../vs140/cbrush-class.md#cbrush__createhatchbrush), [CreatePatternBrush](../vs140/cbrush-class.md#cbrush__createpatternbrush), and [CreateSolidBrush](../vs140/cbrush-class.md#cbrush__createsolidbrush), or retrieved by the <CodeContentPlaceHolder>594\</CodeContentPlaceHolder> Windows function.  
  
 When filling the specified rectangle, <CodeContentPlaceHolder>595\</CodeContentPlaceHolder> does not include the rectangle's right and bottom sides. GDI fills a rectangle up to, but does not include, the right column and bottom row, regardless of the current mapping mode. <CodeContentPlaceHolder>596\</CodeContentPlaceHolder> compares the values of the **top**, **bottom**, **left**, and **right** members of the specified rectangle. If **bottom** is less than or equal to **top**, or if **right** is less than or equal to **left**, the rectangle is not drawn.  
  
 <CodeContentPlaceHolder>597\</CodeContentPlaceHolder> is similar to [CDC::FillSolidRect](#cdc__fillsolidrect); however, <CodeContentPlaceHolder>598\</CodeContentPlaceHolder> takes a brush and therefore can be used to fill a rectangle with a solid color, a dithered color, hatched brushes, or a pattern. <CodeContentPlaceHolder>599\</CodeContentPlaceHolder> uses only solid colors (indicated by a **COLORREF** parameter). <CodeContentPlaceHolder>600\</CodeContentPlaceHolder> usually is slower than <CodeContentPlaceHolder>601\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__fillrgn">\</a>  CDC::FillRgn  
 Fills the region specified by <CodeContentPlaceHolder>602\</CodeContentPlaceHolder> with the brush specified by <CodeContentPlaceHolder>603\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>604\</CodeContentPlaceHolder>  
 A pointer to the region to be filled. The coordinates for the given region are specified in logical units.  
  
 <CodeContentPlaceHolder>605\</CodeContentPlaceHolder>  
 Identifies the brush to be used to fill the region.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The brush must either be created using the <CodeContentPlaceHolder>606\</CodeContentPlaceHolder> member functions <CodeContentPlaceHolder>607\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>608\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>609\</CodeContentPlaceHolder>, or be retrieved by **GetStockObject**.  
  
### Example  
  See the example for [CRgn::CreateRoundRectRgn](../vs140/crgn-class.md#crgn__createroundrectrgn).  
  
##  \<a name="cdc__fillsolidrect">\</a>  CDC::FillSolidRect  
 Call this member function to fill the given rectangle with the specified solid color.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>610\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) data structure or a <CodeContentPlaceHolder>611\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>612\</CodeContentPlaceHolder> Specifies the color to be used to fill the rectangle.  
  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>613\</CodeContentPlaceHolder>  
 Specifies the width of the rectangle.  
  
 <CodeContentPlaceHolder>614\</CodeContentPlaceHolder>  
 Specifies the height of the rectangle.  
  
### Remarks  
 <CodeContentPlaceHolder>615\</CodeContentPlaceHolder> is very similar to [CDC::FillRect](#cdc__fillrect); however, <CodeContentPlaceHolder>616\</CodeContentPlaceHolder> uses only solid colors (indicated by the **COLORREF** parameter), while <CodeContentPlaceHolder>617\</CodeContentPlaceHolder> takes a brush and therefore can be used to fill a rectangle with a solid color, a dithered color, hatched brushes, or a pattern. <CodeContentPlaceHolder>618\</CodeContentPlaceHolder> usually is faster than <CodeContentPlaceHolder>619\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When you call <CodeContentPlaceHolder>620\</CodeContentPlaceHolder>, the background color, which was previously set using [SetBkColor](#cdc__setbkcolor), is set to the color indicated by <CodeContentPlaceHolder>621\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__flattenpath">\</a>  CDC::FlattenPath  
 Transforms any curves in the path selected into the current device context, and turns each curve into a sequence of lines.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
##  \<a name="cdc__floodfill">\</a>  CDC::FloodFill  
 Fills an area of the display surface with the current brush.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point where filling begins.  
  
 *y*  
 Specifies the logical y-coordinate of the point where filling begins.  
  
 <CodeContentPlaceHolder>622\</CodeContentPlaceHolder>  
 Specifies the color of the boundary.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0 is returned if the filling could not be completed, the given point has the boundary color specified by <CodeContentPlaceHolder>623\</CodeContentPlaceHolder>, or the point is outside the clipping region.  
  
### Remarks  
 The area is assumed to be bounded as specified by <CodeContentPlaceHolder>624\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>625\</CodeContentPlaceHolder> function begins at the point specified by                         *x* and                         *y* and continues in all directions to the color boundary.  
  
 Only memory-device contexts and devices that support raster-display technology support the <CodeContentPlaceHolder>626\</CodeContentPlaceHolder> member function. For information about **RC_BITBLT** capability, see the <CodeContentPlaceHolder>627\</CodeContentPlaceHolder> member function.  
  
 The <CodeContentPlaceHolder>628\</CodeContentPlaceHolder> function provides similar capability but greater flexibility.  
  
##  \<a name="cdc__framerect">\</a>  CDC::FrameRect  
 Draws a border around the rectangle specified by <CodeContentPlaceHolder>629\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>630\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the logical coordinates of the upper-left and lower-right corners of the rectangle. You can also pass a <CodeContentPlaceHolder>631\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>632\</CodeContentPlaceHolder>  
 Identifies the brush to be used for framing the rectangle.  
  
### Remarks  
 The function uses the given brush to draw the border. The width and height of the border is always 1 logical unit.  
  
 If the rectangle's **bottom** coordinate is less than or equal to **top**, or if **right** is less than or equal to **left**, the rectangle is not drawn.  
  
 The border drawn by <CodeContentPlaceHolder>633\</CodeContentPlaceHolder> is in the same position as a border drawn by the **Rectangle** member function using the same coordinates (if **Rectangle** uses a pen that is 1 logical unit wide). The interior of the rectangle is not filled by <CodeContentPlaceHolder>634\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__framergn">\</a>  CDC::FrameRgn  
 Draws a border around the region specified by <CodeContentPlaceHolder>635\</CodeContentPlaceHolder> using the brush specified by <CodeContentPlaceHolder>636\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>637\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>638\</CodeContentPlaceHolder> object that identifies the region to be enclosed in a border. The coordinates for the given region are specified in logical units.  
  
 <CodeContentPlaceHolder>639\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>640\</CodeContentPlaceHolder> object that identifies the brush to be used to draw the border.  
  
 <CodeContentPlaceHolder>641\</CodeContentPlaceHolder>  
 Specifies the width of the border in vertical brush strokes in device units.  
  
 <CodeContentPlaceHolder>642\</CodeContentPlaceHolder>  
 Specifies the height of the border in horizontal brush strokes in device units.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Example  
  See the example for [CRgn::CombineRgn](../vs140/crgn-class.md#crgn__combinergn).  
  
##  \<a name="cdc__fromhandle">\</a>  CDC::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>643\</CodeContentPlaceHolder> object when given a handle to a device context.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>644\</CodeContentPlaceHolder>  
 Contains a handle to a Windows device context.  
  
### Return Value  
 The pointer may be temporary and should not be stored beyond immediate use.  
  
### Remarks  
 If a <CodeContentPlaceHolder>645\</CodeContentPlaceHolder> object is not attached to the handle, a temporary <CodeContentPlaceHolder>646\</CodeContentPlaceHolder> object is created and attached.  
  
### Example  
  See the example for [CPrintDialog::GetPrinterDC](../vs140/cprintdialog-class.md#cprintdialog__getprinterdc).  
  
##  \<a name="cdc__getarcdirection">\</a>  CDC::GetArcDirection  
 Returns the current arc direction for the device context.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Return Value  
 Specifies the current arc direction, if successful. Following are the valid return values:  
  
-   **AD_COUNTERCLOCKWISE** Arcs and rectangles drawn counterclockwise.  
  
-   **AD_CLOCKWISE** Arcs and rectangles drawn clockwise.  
  
 If an error occurs, the return value is zero.  
  
### Remarks  
 Arc and rectangle functions use the arc direction.  
  
##  \<a name="cdc__getaspectratiofilter">\</a>  CDC::GetAspectRatioFilter  
 Retrieves the setting for the current aspect-ratio filter.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>647\</CodeContentPlaceHolder> object representing the aspect ratio used by the current aspect ratio filter.  
  
### Remarks  
 The aspect ratio is the ratio formed by a device's pixel width and height. Information about a device's aspect ratio is used in the creation, selection, and display of fonts. Windows provides a special filter, the aspect-ratio filter, to select fonts designed for a particular aspect ratio from all of the available fonts. The filter uses the aspect ratio specified by the <CodeContentPlaceHolder>648\</CodeContentPlaceHolder> member function.  
  
##  \<a name="cdc__getbkcolor">\</a>  CDC::GetBkColor  
 Returns the current background color.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Return Value  
 An RGB color value.  
  
### Remarks  
 If the background mode is **OPAQUE**, the system uses the background color to fill the gaps in styled lines, the gaps between hatched lines in brushes, and the background in character cells. The system also uses the background color when converting bitmaps between color and monochrome device contexts.  
  
##  \<a name="cdc__getbkmode">\</a>  CDC::GetBkMode  
 Returns the background mode.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Return Value  
 The current background mode, which can be **OPAQUE** or **TRANSPARENT**.  
  
### Remarks  
 The background mode defines whether the system removes existing background colors on the drawing surface before drawing text, hatched brushes, or any pen style that is not a solid line.  
  
##  \<a name="cdc__getboundsrect">\</a>  CDC::GetBoundsRect  
 Returns the current accumulated bounding rectangle for the specified device context.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>649\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the current bounding rectangle. The rectangle is returned in logical coordinates.  
  
 <CodeContentPlaceHolder>650\</CodeContentPlaceHolder>  
 Specifies whether the bounding rectangle is to be cleared after it is returned. This parameter should be  zero or set to the following value:  
  
-   **DCB_RESET** Forces the bounding rectangle to be cleared after it is returned.  
  
### Return Value  
 Specifies the current state of the bounding rectangle if the function is successful. It can be a combination of the following values:  
  
-   **DCB_ACCUMULATE** Bounding rectangle accumulation is occurring.  
  
-   **DCB_RESET** Bounding rectangle is empty.  
  
-   **DCB_SET** Bounding rectangle is not empty.  
  
-   **DCB_ENABLE** Bounding accumulation is on.  
  
-   **DCB_DISABLE** Bounding accumulation is off.  
  
##  \<a name="cdc__getbrushorg">\</a>  CDC::GetBrushOrg  
 Retrieves the origin (in device units) of the brush currently selected for the device context.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 The current origin of the brush (in device units) as a [CPoint](../vs140/cpoint-class.md) object.  
  
### Remarks  
 The initial brush origin is at (0,0) of the client area. The return value specifies this point in device units relative to the origin of the desktop window.  
  
##  \<a name="cdc__getcharacterplacement">\</a>  CDC::GetCharacterPlacement  
 Retrieves various types of information on a character string.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>651\</CodeContentPlaceHolder>  
 A pointer to the character string to process.  
  
 <CodeContentPlaceHolder>652\</CodeContentPlaceHolder>  
 Specifies the length of the string. For the ANSI version, it is a BYTE count and for the Unicode function it is a WORD count. For more information, see                                 [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx).  
  
 <CodeContentPlaceHolder>653\</CodeContentPlaceHolder>  
 Specifies the maximum extent (in logical units) to which the string is processed. Characters that, if processed, would exceed this extent are ignored. Computations for any required ordering or glyph arrays apply only to the included characters. This parameter is used only if the GCP_MAXEXTENT value is specified in the <CodeContentPlaceHolder>654\</CodeContentPlaceHolder> parameter. As the function processes the input string, each character and its extent is added to the output, extent, and other arrays only if the total extent has not yet exceeded the maximum. Once the limit is reached, processing will stop.  
  
 lpResults  
 Pointer to a                                 [GCP_Results](http://msdn.microsoft.com/library/windows/desktop/dd144842\(v=vs.85\).aspx) structure that receives the results of the function.  
  
 <CodeContentPlaceHolder>655\</CodeContentPlaceHolder>  
 Specifies how to process the string into the required arrays. This parameter can be one or more of the values listed in the <CodeContentPlaceHolder>656\</CodeContentPlaceHolder> section of the                                 [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx) topic.  
  
 <CodeContentPlaceHolder>657\</CodeContentPlaceHolder>  
 A pointer to a [CString](../vs140/cstringt-class.md) object to process.  
  
### Return Value  
 If the function succeeds, the return value is the width and height of the string in logical units.  
  
 If the function fails, the return value is zero.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetCharacterPlacement](http://msdn.microsoft.com/library/windows/desktop/dd144860\(v=vs.85\).aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getcharabcwidths">\</a>  CDC::GetCharABCWidths  
 Retrieves the widths of consecutive characters in a specified range from the current TrueType font.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>658\</CodeContentPlaceHolder>  
 Specifies the first character in the range of characters from the current font for which character widths are returned.  
  
 <CodeContentPlaceHolder>659\</CodeContentPlaceHolder>  
 Specifies the last character in the range of characters from the current font for which character widths are returned.  
  
 <CodeContentPlaceHolder>660\</CodeContentPlaceHolder>  
 Points to an array of [ABC](../vs140/abc-structure.md) structures that receive the character widths when the function returns. This array must contain at least as many **ABC** structures as there are characters in the range specified by the <CodeContentPlaceHolder>661\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>662\</CodeContentPlaceHolder> parameters.  
  
 *lpABCF*  
 Points to an application-supplied buffer with an array of [ABCFLOAT](../vs140/abcfloat-structure.md) structures to receive the character widths when the function returns. The widths returned by this function are in the IEEE floating-point format.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The widths are returned in logical units. This function succeeds only with TrueType fonts.  
  
 The TrueType rasterizer provides "ABC" character spacing after a specific point size has been selected. "A" spacing is the distance that is added to the current position before placing the glyph. "B" spacing is the width of the black part of the glyph. "C" spacing is added to the current position to account for the white space to the right of the glyph. The total advanced width is given by A + B + C.  
  
 When the <CodeContentPlaceHolder>663\</CodeContentPlaceHolder> member function retrieves negative "A" or "C" widths for a character, that character includes underhangs or overhangs.  
  
 To convert the ABC widths to font design units, an application should create a font whose height (as specified in the **lfHeight** member of the                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure) is equal to the value stored in the **ntmSizeEM** member of the                         [NEWTEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162741) structure. (The value of the **ntmSizeEM** member can be retrieved by calling the                         [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619) Windows function.)  
  
 The ABC widths of the default character are used for characters that are outside the range of the currently selected font.  
  
 To retrieve the widths of characters in non-TrueType fonts, applications should use the                         [GetCharWidth](http://msdn.microsoft.com/library/windows/desktop/dd144861) Windows function.  
  
##  \<a name="cdc__getcharabcwidthsi">\</a>  CDC::GetCharABCWidthsI  
 Retrieves the widths, in logical units, of consecutive glyph indices in a specified range from the current TrueType font.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>664\</CodeContentPlaceHolder>  
 Specifies the first glyph index in the group of consecutive glyph indices from the current font. This parameter is only used if the <CodeContentPlaceHolder>665\</CodeContentPlaceHolder> parameter is **NULL**.  
  
 <CodeContentPlaceHolder>666\</CodeContentPlaceHolder>  
 Specifies the number of glyph indices.  
  
 <CodeContentPlaceHolder>667\</CodeContentPlaceHolder>  
 A pointer to an array containing glyph indices. If the value is **NULL**, the <CodeContentPlaceHolder>668\</CodeContentPlaceHolder> parameter is used instead. The <CodeContentPlaceHolder>669\</CodeContentPlaceHolder> parameter specifies the number of glyph indices in this array.  
  
 <CodeContentPlaceHolder>670\</CodeContentPlaceHolder>  
 Pointer to an array of                                 [ABC](http://msdn.microsoft.com/library/windows/desktop/dd162454) structures receiving the character widths. This array must contain at least as many **ABC** structures as there are glyph indices specified by the <CodeContentPlaceHolder>671\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetCharABCWidthsI](http://msdn.microsoft.com/library/windows/desktop/dd144859), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getcharwidth">\</a>  CDC::GetCharWidth  
 Retrieves the widths of individual characters in a consecutive group of characters from the current font, using <CodeContentPlaceHolder>672\</CodeContentPlaceHolder>, the input device context.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>673\</CodeContentPlaceHolder>  
 Specifies the first character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>674\</CodeContentPlaceHolder>  
 Specifies the last character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>675\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the width values for a consecutive group of characters in the current font.  
  
 *lpFloatBuffer*  
 Points to a buffer to receive the character widths. The returned widths are in the 32-bit IEEE floating-point format. (The widths are measured along the base line of the characters.)  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 For example, if <CodeContentPlaceHolder>676\</CodeContentPlaceHolder> identifies the letter 'a' and <CodeContentPlaceHolder>677\</CodeContentPlaceHolder> identifies the letter 'z', the function retrieves the widths of all lowercase characters.  
  
 The function stores the values in the buffer pointed to by <CodeContentPlaceHolder>678\</CodeContentPlaceHolder>. This buffer must be large enough to hold all of the widths. That is, there must be at least 26 entries in the example given.  
  
 If a character in the consecutive group of characters does not exist in a particular font, it will be assigned the width value of the default character.  
  
##  \<a name="cdc__getcharwidthi">\</a>  CDC::GetCharWidthI  
 Retrieves the widths, in logical coordinates, of consecutive glyph indices in a specified range from the current font.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>679\</CodeContentPlaceHolder>  
 Specifies the first glyph index in the group of consecutive glyph indices from the current font. This parameter is only used if the <CodeContentPlaceHolder>680\</CodeContentPlaceHolder> parameter is **NULL**.  
  
 <CodeContentPlaceHolder>681\</CodeContentPlaceHolder>  
 Specifies the number of glyph indices.  
  
 <CodeContentPlaceHolder>682\</CodeContentPlaceHolder>  
 A pointer to an array containing glyph indices. If the value is **NULL**, the <CodeContentPlaceHolder>683\</CodeContentPlaceHolder> parameter is used instead. The <CodeContentPlaceHolder>684\</CodeContentPlaceHolder> parameter specifies the number of glyph indices in this array.  
  
 <CodeContentPlaceHolder>685\</CodeContentPlaceHolder>  
 A pointer to a buffer that receives the widths.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetCharWidthI](http://msdn.microsoft.com/library/windows/desktop/dd144864), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getclipbox">\</a>  CDC::GetClipBox  
 Retrieves the dimensions of the tightest bounding rectangle around the current clipping boundary.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>686\</CodeContentPlaceHolder>  
 Points to the [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that is to receive the rectangle dimensions.  
  
### Return Value  
 The clipping region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** Clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** Clipping region is empty.  
  
-   **SIMPLEREGION** Clipping region has no overlapping borders.  
  
### Remarks  
 The dimensions are copied to the buffer pointed to by <CodeContentPlaceHolder>687\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__getcoloradjustment">\</a>  CDC::GetColorAdjustment  
 Retrieves the color adjustment values for the device context.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>688\</CodeContentPlaceHolder>  
 Points to a [COLORADJUSTMENT](../vs140/coloradjustment-structure.md) data structure to receive the color adjustment values.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
##  \<a name="cdc__getcurrentbitmap">\</a>  CDC::GetCurrentBitmap  
 Returns a pointer to the currently selected <CodeContentPlaceHolder>689\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>690\</CodeContentPlaceHolder> object, if successful; otherwise **NULL**.  
  
### Remarks  
 This member function may return temporary objects.  
  
##  \<a name="cdc__getcurrentbrush">\</a>  CDC::GetCurrentBrush  
 Returns a pointer to the currently selected <CodeContentPlaceHolder>691\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>692\</CodeContentPlaceHolder> object, if successful; otherwise **NULL**.  
  
### Remarks  
 This member function may return temporary objects.  
  
##  \<a name="cdc__getcurrentfont">\</a>  CDC::GetCurrentFont  
 Returns a pointer to the currently selected <CodeContentPlaceHolder>693\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>694\</CodeContentPlaceHolder> object, if successful; otherwise **NULL**.  
  
### Remarks  
 This member function may return temporary objects.  
  
##  \<a name="cdc__getcurrentpalette">\</a>  CDC::GetCurrentPalette  
 Returns a pointer to the currently selected <CodeContentPlaceHolder>695\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>696\</CodeContentPlaceHolder> object, if successful; otherwise **NULL**.  
  
### Remarks  
 This member function may return temporary objects.  
  
##  \<a name="cdc__getcurrentpen">\</a>  CDC::GetCurrentPen  
 Returns a pointer to the currently selected <CodeContentPlaceHolder>697\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>698\</CodeContentPlaceHolder> object, if successful; otherwise **NULL**.  
  
### Remarks  
 This member function may return temporary objects.  
  
##  \<a name="cdc__getcurrentposition">\</a>  CDC::GetCurrentPosition  
 Retrieves the current position (in logical coordinates).  
  
<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
### Return Value  
 The current position as a <CodeContentPlaceHolder>699\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The current position can be set with the <CodeContentPlaceHolder>700\</CodeContentPlaceHolder> member function.  
  
##  \<a name="cdc__getdcbrushcolor">\</a>  CDC::GetDCBrushColor  
 Retrieves the current brush color.  
  
<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
### Return Value  
 If the function succeeds, the return value is the                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value for the current brush color.  
  
 If the function fails, the return value is **CLR_INVALID**.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetDCBrushColor](http://msdn.microsoft.com/library/windows/desktop/dd144872), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getdcpencolor">\</a>  CDC::GetDCPenColor  
 Retrieves the current pen color.  
  
<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
### Return Value  
 If the function succeeds, the return value is the                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value for the current pen color.  
  
 If the function fails, the return value is **CLR_INVALID**.  
  
### Remarks  
 This member function utilizes the Win32 function                         [GetDCPenColor](http://msdn.microsoft.com/library/windows/desktop/dd144875), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getdevicecaps">\</a>  CDC::GetDeviceCaps  
 Retrieves a wide range of device-specific information about the display device.  
  
<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>701\</CodeContentPlaceHolder>  
 Specifies the type of information to return. See                                 [GetDeviceCaps](http://msdn.microsoft.com/library/windows/desktop/dd144877) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
### Return Value  
 The value of the requested capability if the function is successful.  
  
### Example  
  See the example for [CPrintDialog::GetDefaults](../vs140/cprintdialog-class.md#cprintdialog__getdefaults).  
  
##  \<a name="cdc__getfontdata">\</a>  CDC::GetFontData  
 Retrieves font-metric information from a scalable font file.  
  
<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>702\</CodeContentPlaceHolder>  
 Specifies the name of the metric table to be returned. This parameter can be one of the metric tables documented in the TrueType Font Files specification published by Microsoft Corporation. If this parameter is 0, the information is retrieved starting at the beginning of the font file.  
  
 <CodeContentPlaceHolder>703\</CodeContentPlaceHolder>  
 Specifies the offset from the beginning of the table at which to begin retrieving information. If this parameter is 0, the information is retrieved starting at the beginning of the table specified by the <CodeContentPlaceHolder>704\</CodeContentPlaceHolder> parameter. If this value is greater than or equal to the size of the table, <CodeContentPlaceHolder>705\</CodeContentPlaceHolder> returns 0.  
  
 <CodeContentPlaceHolder>706\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the font information. If this value is **NULL**, the function returns the size of the buffer required for the font data specified in the <CodeContentPlaceHolder>707\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>708\</CodeContentPlaceHolder>  
 Specifies the length, in bytes, of the information to be retrieved. If this parameter is 0, <CodeContentPlaceHolder>709\</CodeContentPlaceHolder> returns the size of the data specified in the <CodeContentPlaceHolder>710\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 Specifies the number of bytes returned in the buffer pointed to by <CodeContentPlaceHolder>711\</CodeContentPlaceHolder> if the function is successful; otherwise –1.  
  
### Remarks  
 The information to retrieve is identified by specifying an offset into the font file and the length of the information to return.  
  
 An application can sometimes use the <CodeContentPlaceHolder>712\</CodeContentPlaceHolder> member function to save a TrueType font with a document. To do this, the application determines whether the font can be embedded and then retrieves the entire font file, specifying 0 for the <CodeContentPlaceHolder>713\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>714\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>715\</CodeContentPlaceHolder> parameters.  
  
 Applications can determine whether a font can be embedded by checking the **otmfsType** member of the                         [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structure. If bit 1 of **otmfsType** is set, embedding is not permitted for the font. If bit 1 is clear, the font can be embedded. If bit 2 is set, the embedding is read only.  
  
 If an application attempts to use this function to retrieve information for a non-TrueType font, the <CodeContentPlaceHolder>716\</CodeContentPlaceHolder> member function returns –1.  
  
##  \<a name="cdc__getfontlanguageinfo">\</a>  CDC::GetFontLanguageInfo  
 Returns information about the currently selected font for the specified display context.  
  
<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
### Return Value  
 The return value identifies characteristics of the currently selected font. For a complete listing of possible values, see                         [GetFontLanguageInfo](http://msdn.microsoft.com/library/windows/desktop/dd144886).  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetFontLanguageInfo](http://msdn.microsoft.com/library/windows/desktop/dd144886), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__getglyphoutline">\</a>  CDC::GetGlyphOutline  
 Retrieves the outline curve or bitmap for an outline character in the current font.  
  
<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>717\</CodeContentPlaceHolder>  
 Specifies the character for which information is to be returned.  
  
 <CodeContentPlaceHolder>718\</CodeContentPlaceHolder>  
 Specifies the format in which the function is to return information. It can be one of the following values, or 0:  
  
|Value|Meaning|  
|-----------|-------------|  
|**GGO_BITMAP**|Returns the glyph bitmap. When the function returns, the buffer pointed to by <CodeContentPlaceHolder>719\</CodeContentPlaceHolder> contains a 1-bit-per-pixel bitmap whose rows start on doubleword boundaries.|  
|**GGO_NATIVE**|Returns the curve data points in the rasterizer's native format, using device units. When this value is specified, any transformation specified in <CodeContentPlaceHolder>720\</CodeContentPlaceHolder> is ignored.|  
  
 When the value of <CodeContentPlaceHolder>721\</CodeContentPlaceHolder> is 0, the function fills in a                                 [GLYPHMETRICS](http://msdn.microsoft.com/library/windows/desktop/dd144955) structure but does not return glyph-outline data.  
  
 *lpgm*  
 Points to a **GLYPHMETRICS** structure that describes the placement of the glyph in the character cell.  
  
 <CodeContentPlaceHolder>722\</CodeContentPlaceHolder>  
 Specifies the size of the buffer into which the function copies information about the outline character. If this value is 0 and the <CodeContentPlaceHolder>723\</CodeContentPlaceHolder> parameter is either the **GGO_BITMAP** or **GGO_NATIVE** values, the function returns the required size of the buffer.  
  
 <CodeContentPlaceHolder>724\</CodeContentPlaceHolder>  
 Points to a buffer into which the function copies information about the outline character. If <CodeContentPlaceHolder>725\</CodeContentPlaceHolder> specifies the **GGO_NATIVE** value, the information is copied in the form of **TTPOLYGONHEADER** and **TTPOLYCURVE** structures. If this value is **NULL** and <CodeContentPlaceHolder>726\</CodeContentPlaceHolder> is either the **GGO_BITMAP** or **GGO_NATIVE** value, the function returns the required size of the buffer.  
  
 <CodeContentPlaceHolder>727\</CodeContentPlaceHolder>  
 Points to a                                 [MAT2](http://msdn.microsoft.com/library/windows/desktop/dd145048) structure that contains a transformation matrix for the character. This parameter cannot be **NULL**, even when the **GGO_NATIVE** value is specified for <CodeContentPlaceHolder>728\</CodeContentPlaceHolder>.  
  
### Return Value  
 The size, in bytes, of the buffer required for the retrieved information if <CodeContentPlaceHolder>729\</CodeContentPlaceHolder> is 0 or <CodeContentPlaceHolder>730\</CodeContentPlaceHolder> is **NULL**. Otherwise, it is a positive value if the function is successful, or –1 if there is an error.  
  
### Remarks  
 An application can rotate characters retrieved in bitmap format by specifying a 2-by-2 transformation matrix in the structure pointed to by <CodeContentPlaceHolder>731\</CodeContentPlaceHolder>.  
  
 A glyph outline is returned as a series of contours. Each contour is defined by a                         [TTPOLYGONHEADER](http://msdn.microsoft.com/library/windows/desktop/dd145158) structure followed by as many **TTPOLYCURVE** structures as are required to describe it. All points are returned as                         [POINTFX](http://msdn.microsoft.com/library/windows/desktop/dd162806) structures and represent absolute positions, not relative moves. The starting point given by the **pfxStart** member of the                         [TTPOLYGONHEADER](http://msdn.microsoft.com/library/windows/desktop/dd145158) structure is the point at which the outline for a contour begins. The                         [TTPOLYCURVE](http://msdn.microsoft.com/library/windows/desktop/dd145157) structures that follow can be either polyline records or spline records. Polyline records are a series of points; lines drawn between the points describe the outline of the character. Spline records represent the quadratic curves used by TrueType (that is, quadratic b-splines).  
  
##  \<a name="cdc__getgraphicsmode">\</a>  CDC::GetGraphicsMode  
 Retrieves the current graphics mode for the specified device context.  
  
<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
### Return Value  
 Returns the current graphics mode on success. For a list of the values that this method can return, see                         [GetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd144892).  
  
 Returns 0 on failure.  
  
 To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This method wraps the Windows GDI function                         [GetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd144892).  
  
##  \<a name="cdc__gethalftonebrush">\</a>  CDC::GetHalftoneBrush  
 Call this member function to retrieve a halftone brush.  
  
<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>732\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 A halftone brush shows pixels that are alternately foreground and background colors to create a dithered pattern. The following is an example of a dithered pattern created by a halftone brush.  
  
 ![Detail of a dithered pen stroke](../vs140/media/vc318s1.gif "vc318S1")  
  
##  \<a name="cdc__getkerningpairs">\</a>  CDC::GetKerningPairs  
 Retrieves the character kerning pairs for the font that is currently selected in the specified device context.  
  
<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>733\</CodeContentPlaceHolder>  
 Specifies the number of                                 [KERNINGPAIR](http://msdn.microsoft.com/library/windows/desktop/dd145024) structures pointed to by <CodeContentPlaceHolder>734\</CodeContentPlaceHolder>. The function will not copy more kerning pairs than specified by <CodeContentPlaceHolder>735\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>736\</CodeContentPlaceHolder>  
 Points to an array of **KERNINGPAIR** structures that receive the kerning pairs when the function returns. This array must contain at least as many structures as specified by <CodeContentPlaceHolder>737\</CodeContentPlaceHolder>. If this parameter is **NULL**, the function returns the total number of kerning pairs for the font.  
  
### Return Value  
 Specifies the number of kerning pairs retrieved or the total number of kerning pairs in the font, if the function is successful. Zero is returned if the function fails or there are no kerning pairs for the font.  
  
##  \<a name="cdc__getlayout">\</a>  CDC::GetLayout  
 Call this member function to determine the layout of the text and graphics for a device context, such as a printer or a metafile.  
  
<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
### Return Value  
 If successful, the layout flags for the current device context. Otherwise, **GDI_ERROR**. For extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). For a list of the layout flags, see [CDC::SetLayout](#cdc__setlayout).  
  
### Remarks  
 The default layout is left to right.  
  
##  \<a name="cdc__getmapmode">\</a>  CDC::GetMapMode  
 Retrieves the current mapping mode.  
  
<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
### Return Value  
 The mapping mode.  
  
### Remarks  
 For a description of the mapping modes, see the <CodeContentPlaceHolder>738\</CodeContentPlaceHolder> member function.  
  
> [!NOTE]
>  If you call [SetLayout](#cdc__setlayout) to change the DC to right-to-left layout, **SetLayout** automatically changes the mapping mode to <CodeContentPlaceHolder>739\</CodeContentPlaceHolder>. Consequently, any subsequent call to <CodeContentPlaceHolder>740\</CodeContentPlaceHolder> will return <CodeContentPlaceHolder>741\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__getmiterlimit">\</a>  CDC::GetMiterLimit  
 Returns the miter limit for the device context.  
  
<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The miter limit is used when drawing geometric lines that have miter joins.  
  
##  \<a name="cdc__getnearestcolor">\</a>  CDC::GetNearestColor  
 Returns the solid color that best matches a specified logical color.  
  
<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>742\</CodeContentPlaceHolder>  
 Specifies the color to be matched.  
  
### Return Value  
 An RGB (red, green, blue) color value that defines the solid color closest to the <CodeContentPlaceHolder>743\</CodeContentPlaceHolder> value that the device can represent.  
  
### Remarks  
 The given device must be able to represent this color.  
  
##  \<a name="cdc__getoutlinetextmetrics">\</a>  CDC::GetOutlineTextMetrics  
 Retrieves metric information for TrueType fonts.  
  
<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>744\</CodeContentPlaceHolder>  
 Points to an array of                                 [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structures. If this parameter is **NULL**, the function returns the size of the buffer required for the retrieved metric data.  
  
 <CodeContentPlaceHolder>745\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the buffer to which information is returned.  
  
 <CodeContentPlaceHolder>746\</CodeContentPlaceHolder>  
 Points to an **OUTLINETEXTMETRIC** structure. If this parameter is **NULL**, the function returns the size of the buffer required for the retrieved metric information.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The                         [OUTLINETEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd162755) structure contains most of the font metric information provided with the TrueType format, including a                         [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure. The last four members of the **OUTLINETEXTMETRIC** structure are pointers to strings. Applications should allocate space for these strings in addition to the space required for the other members. Because there is no system-imposed limit to the size of the strings, the simplest method for allocating memory is to retrieve the required size by specifying **NULL** for <CodeContentPlaceHolder>747\</CodeContentPlaceHolder> in the first call to the <CodeContentPlaceHolder>748\</CodeContentPlaceHolder> function.  
  
##  \<a name="cdc__getoutputcharwidth">\</a>  CDC::GetOutputCharWidth  
 Uses the output device context, <CodeContentPlaceHolder>749\</CodeContentPlaceHolder>, and retrieves the widths of individual characters in a consecutive group of characters from the current font.  
  
<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>750\</CodeContentPlaceHolder>  
 Specifies the first character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>751\</CodeContentPlaceHolder>  
 Specifies the last character in a consecutive group of characters in the current font.  
  
 <CodeContentPlaceHolder>752\</CodeContentPlaceHolder>  
 Points to a buffer that will receive the width values for a consecutive group of characters in the current font.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 For example, if <CodeContentPlaceHolder>753\</CodeContentPlaceHolder> identifies the letter 'a' and <CodeContentPlaceHolder>754\</CodeContentPlaceHolder> identifies the letter 'z', the function retrieves the widths of all lowercase characters.  
  
 The function stores the values in the buffer pointed to by <CodeContentPlaceHolder>755\</CodeContentPlaceHolder>. This buffer must be large enough to hold all of the widths; that is, there must be at least 26 entries in the example given.  
  
 If a character in the consecutive group of characters does not exist in a particular font, it will be assigned the width value of the default character.  
  
##  \<a name="cdc__getoutputtabbedtextextent">\</a>  CDC::GetOutputTabbedTextExtent  
 Call this member function to compute the width and height of a character string using [m_hDC](#cdc__m_hdc), the output device context.  
  
<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>756\</CodeContentPlaceHolder>  
 Points to a character string to be measured. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>757\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>758\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>759\</CodeContentPlaceHolder>  
 Specifies the number of tab-stop positions in the array pointed to by <CodeContentPlaceHolder>760\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>761\</CodeContentPlaceHolder>  
 Points to an array of integers containing the tab-stop positions in logical units. The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array. Back tabs are not allowed.  
  
 <CodeContentPlaceHolder>762\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>763\</CodeContentPlaceHolder> object that contains the specified characters to be measured.  
  
### Return Value  
 The dimensions of the string (in logical units) in a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 If the string contains one or more tab characters, the width of the string is based upon the tab stops specified by <CodeContentPlaceHolder>764\</CodeContentPlaceHolder>. The function uses the currently selected font to compute the dimensions of the string.  
  
 The current clipping region does not offset the width and height returned by the <CodeContentPlaceHolder>765\</CodeContentPlaceHolder> function.  
  
 Since some devices do not place characters in regular cell arrays (that is, they kern the characters), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
 If <CodeContentPlaceHolder>766\</CodeContentPlaceHolder> is 0 and <CodeContentPlaceHolder>767\</CodeContentPlaceHolder> is **NULL**, tabs are expanded to eight average character widths. If <CodeContentPlaceHolder>768\</CodeContentPlaceHolder> is 1, the tab stops will be separated by the distance specified by the first value in the array to which <CodeContentPlaceHolder>769\</CodeContentPlaceHolder> points. If <CodeContentPlaceHolder>770\</CodeContentPlaceHolder> points to more than a single value, a tab stop is set for each value in the array, up to the number specified by <CodeContentPlaceHolder>771\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__getoutputtextextent">\</a>  CDC::GetOutputTextExtent  
 Call this member function to use the output device context, [m_hDC](#cdc__m_hdc), and compute the width and height of a line of text, using the current font.  
  
<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>772\</CodeContentPlaceHolder>  
 Points to a string of characters. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>773\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>774\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>775\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>776\</CodeContentPlaceHolder> object that contains the specified characters to be measured.  
  
### Return Value  
 The dimensions of the string (in logical units) returned in a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 The current clipping region does not affect the width and height returned by <CodeContentPlaceHolder>777\</CodeContentPlaceHolder>.  
  
 Since some devices do not place characters in regular cell arrays (that is, they carry out kerning), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
##  \<a name="cdc__getoutputtextmetrics">\</a>  CDC::GetOutputTextMetrics  
 Retrieves the metrics for the current font using <CodeContentPlaceHolder>778\</CodeContentPlaceHolder>, the output device context.  
  
<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>779\</CodeContentPlaceHolder>  
 Points to the                                 [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure that receives the metrics.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
##  \<a name="cdc__getpath">\</a>  CDC::GetPath  
 Retrieves the coordinates defining the endpoints of lines and the control points of curves found in the path that is selected into the device context.  
  
<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>780\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures or <CodeContentPlaceHolder>781\</CodeContentPlaceHolder> objects where the line endpoints and curve control points are placed.  
  
 <CodeContentPlaceHolder>782\</CodeContentPlaceHolder>  
 Points to an array of bytes where the vertex types are placed. Values are one of the following:  
  
-   **PT_MOVETO** Specifies that the corresponding point in <CodeContentPlaceHolder>783\</CodeContentPlaceHolder> starts a disjoint figure.  
  
-   **PT_LINETO** Specifies that the previous point and the corresponding point in <CodeContentPlaceHolder>784\</CodeContentPlaceHolder> are the endpoints of a line.  
  
-   **PT_BEZIERTO** Specifies that the corresponding point in <CodeContentPlaceHolder>785\</CodeContentPlaceHolder> is a control point or ending point for a Bzier curve.  
  
     **PT_BEZIERTO** types always occur in sets of three. The point in the path immediately preceding them defines the starting point for the Bzier curve. The first two **PT_BEZIERTO** points are the control points, and the third **PT_BEZIERTO** point is the end point (if hard-coded).  
  
     A **PT_LINETO** or **PT_BEZIERTO** type may be combined with the following flag (by using the bitwise operator <CodeContentPlaceHolder>786\</CodeContentPlaceHolder>) to indicate that the corresponding point is the last point in a figure and that the figure should be closed:  
  
-   **PT_CLOSEFIGURE** Specifies that the figure is automatically closed after the corresponding line or curve is drawn. The figure is closed by drawing a line from the line or curve endpoint to the point corresponding to the last **PT_MOVETO**.  
  
 <CodeContentPlaceHolder>787\</CodeContentPlaceHolder>  
 Specifies the total number of [POINT](../vs140/point-structure.md) data structures that may be placed in the <CodeContentPlaceHolder>788\</CodeContentPlaceHolder> array. This value must be the same as the number of bytes that may be placed in the <CodeContentPlaceHolder>789\</CodeContentPlaceHolder> array.  
  
### Return Value  
 If the <CodeContentPlaceHolder>790\</CodeContentPlaceHolder> parameter is nonzero, the number of points enumerated. If <CodeContentPlaceHolder>791\</CodeContentPlaceHolder> is 0, the total number of points in the path (and <CodeContentPlaceHolder>792\</CodeContentPlaceHolder> writes nothing to the buffers). If <CodeContentPlaceHolder>793\</CodeContentPlaceHolder> is nonzero and is less than the number of points in the path, the return value is -1.  
  
### Remarks  
 The device context must contain a closed path. The points of the path are returned in logical coordinates. Points are stored in the path in device coordinates, so <CodeContentPlaceHolder>794\</CodeContentPlaceHolder> changes the points from device coordinates to logical coordinates by using the inverse of the current transformation. The <CodeContentPlaceHolder>795\</CodeContentPlaceHolder> member function may be called before <CodeContentPlaceHolder>796\</CodeContentPlaceHolder>, to convert all curves in the path into line segments.  
  
### Example  
  See the example for [CDC::BeginPath](#cdc__beginpath).  
  
##  \<a name="cdc__getpixel">\</a>  CDC::GetPixel  
 Retrieves the RGB color value of the pixel at the point specified by                 *x* and                 *y*.  
  
<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point to be examined.  
  
 *y*  
 Specifies the logical y-coordinate of the point to be examined.  
  
 <CodeContentPlaceHolder>797\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the point to be examined.  
  
### Return Value  
 For either version of the function, an RGB color value for the color of the given point. It is –1 if the coordinates do not specify a point in the clipping region.  
  
### Remarks  
 The point must be in the clipping region. If the point is not in the clipping region, the function has no effect and returns –1.  
  
 Not all devices support the **GetPixel** function. For more information, see the **RC_BITBLT** raster capability under the [GetDeviceCaps](#cdc__getdevicecaps) member function.  
  
 The **GetPixel** member function has two forms. The first takes two coordinate values; the second takes either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object.  
  
##  \<a name="cdc__getpolyfillmode">\</a>  CDC::GetPolyFillMode  
 Retrieves the current polygon-filling mode.  
  
<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
### Return Value  
 The current polygon-filled mode, **ALTERNATE** or **WINDING**, if the function is successful.  
  
### Remarks  
 See the <CodeContentPlaceHolder>798\</CodeContentPlaceHolder> member function for a description of the polygon-filling modes.  
  
##  \<a name="cdc__getrop2">\</a>  CDC::GetROP2  
 Retrieves the current drawing mode.  
  
<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
### Return Value  
 The drawing mode. For a list of the drawing mode values, see the <CodeContentPlaceHolder>799\</CodeContentPlaceHolder> member function.  
  
### Remarks  
 The drawing mode specifies how the colors of the pen and the interior of filled objects are combined with the color already on the display surface.  
  
##  \<a name="cdc__getsafehdc">\</a>  CDC::GetSafeHdc  
 Call this member function to get [m_hDC](#cdc__m_hdc), the output device context.  
  
<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
### Return Value  
 A device context handle.  
  
### Remarks  
 This member function also works with null pointers.  
  
##  \<a name="cdc__getstretchbltmode">\</a>  CDC::GetStretchBltMode  
 Retrieves the current bitmap-stretching mode.  
  
<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
### Return Value  
 The return value specifies the current bitmap-stretching mode — **STRETCH_ANDSCANS**, **STRETCH_DELETESCANS**, or **STRETCH_ORSCANS** — if the function is successful.  
  
### Remarks  
 The bitmap-stretching mode defines how information is removed from bitmaps that are stretched or compressed by the <CodeContentPlaceHolder>800\</CodeContentPlaceHolder> member function.  
  
 The **STRETCH_ANDSCANS** and **STRETCH_ORSCANS** modes are typically used to preserve foreground pixels in monochrome bitmaps. The **STRETCH_DELETESCANS** mode is typically used to preserve color in color bitmaps.  
  
##  \<a name="cdc__gettabbedtextextent">\</a>  CDC::GetTabbedTextExtent  
 Call this member function to compute the width and height of a character string using [m_hAttribDC](#cdc__m_hattribdc), the attribute device context.  
  
<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>801\</CodeContentPlaceHolder>  
 Points to a character string. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>802\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>803\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>804\</CodeContentPlaceHolder>  
 Specifies the number of tab-stop positions in the array pointed to by <CodeContentPlaceHolder>805\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>806\</CodeContentPlaceHolder>  
 Points to an array of integers containing the tab-stop positions in logical units. The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array. Back tabs are not allowed.  
  
 <CodeContentPlaceHolder>807\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>808\</CodeContentPlaceHolder> object that contains the specified characters to be drawn.  
  
### Return Value  
 The dimensions of the string (in logical units) in a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 If the string contains one or more tab characters, the width of the string is based upon the tab stops specified by <CodeContentPlaceHolder>809\</CodeContentPlaceHolder>. The function uses the currently selected font to compute the dimensions of the string.  
  
 The current clipping region does not offset the width and height returned by the <CodeContentPlaceHolder>810\</CodeContentPlaceHolder> function.  
  
 Since some devices do not place characters in regular cell arrays (that is, they kern the characters), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
 If <CodeContentPlaceHolder>811\</CodeContentPlaceHolder> is 0 and <CodeContentPlaceHolder>812\</CodeContentPlaceHolder> is **NULL**, tabs are expanded to eight times the average character width. If <CodeContentPlaceHolder>813\</CodeContentPlaceHolder> is 1, the tab stops will be separated by the distance specified by the first value in the array to which <CodeContentPlaceHolder>814\</CodeContentPlaceHolder> points. If <CodeContentPlaceHolder>815\</CodeContentPlaceHolder> points to more than a single value, a tab stop is set for each value in the array, up to the number specified by <CodeContentPlaceHolder>816\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__gettextalign">\</a>  CDC::GetTextAlign  
 Retrieves the status of the text-alignment flags for the device context.  
  
<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
### Return Value  
 The status of the text-alignment flags. The return value is one or more of the following values:  
  
-   **TA_BASELINE** Specifies alignment of the x-axis and the baseline of the chosen font within the bounding rectangle.  
  
-   **TA_BOTTOM** Specifies alignment of the x-axis and the bottom of the bounding rectangle.  
  
-   **TA_CENTER** Specifies alignment of the y-axis and the center of the bounding rectangle.  
  
-   **TA_LEFT** Specifies alignment of the y-axis and the left side of the bounding rectangle.  
  
-   **TA_NOUPDATECP** Specifies that the current position is not updated.  
  
-   **TA_RIGHT** Specifies alignment of the y-axis and the right side of the bounding rectangle.  
  
-   **TA_TOP** Specifies alignment of the x-axis and the top of the bounding rectangle.  
  
-   **TA_UPDATECP** Specifies that the current position is updated.  
  
### Remarks  
 The text-alignment flags determine how the <CodeContentPlaceHolder>817\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>818\</CodeContentPlaceHolder> member functions align a string of text in relation to the string's starting point. The text-alignment flags are not necessarily single-bit flags and may be equal to 0. To test whether a flag is set, an application should follow these steps:  
  
1.  Apply the bitwise OR operator to the flag and its related flags, grouped as follows:  
  
    -   **TA_LEFT**, **TA_CENTER**, and **TA_RIGHT**  
  
    -   **TA_BASELINE**, **TA_BOTTOM**, and **TA_TOP**  
  
    -   **TA_NOUPDATECP** and **TA_UPDATECP**  
  
2.  Apply the bitwise-AND operator to the result and the return value of <CodeContentPlaceHolder>819\</CodeContentPlaceHolder>.  
  
3.  Test for the equality of this result and the flag.  
  
##  \<a name="cdc__gettextcharacterextra">\</a>  CDC::GetTextCharacterExtra  
 Retrieves the current setting for the amount of intercharacter spacing.  
  
<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
### Return Value  
 The amount of the intercharacter spacing.  
  
### Remarks  
 GDI adds this spacing to each character, including break characters, when it writes a line of text to the device context.  
  
 The default value for the amount of intercharacter spacing is 0.  
  
##  \<a name="cdc__gettextcolor">\</a>  CDC::GetTextColor  
 Retrieves the current text color.  
  
<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
### Return Value  
 The current text color as an RGB color value.  
  
### Remarks  
 The text color is the foreground color of characters drawn by using the GDI text-output member functions [TextOut](#cdc__textout), [ExtTextOut](#cdc__exttextout), and [TabbedTextOut](#cdc__tabbedtextout).  
  
##  \<a name="cdc__gettextextent">\</a>  CDC::GetTextExtent  
 Call this member function to compute the width and height of a line of text using the current font to determine the dimensions.  
  
<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>820\</CodeContentPlaceHolder>  
 Points to a string of characters. You can also pass a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>821\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string.  
  
 <CodeContentPlaceHolder>822\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>823\</CodeContentPlaceHolder> object that contains the specified characters.  
  
### Return Value  
 The dimensions of the string (in logical units) in a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 The information is retrieved from [m_hAttribDC](#cdc__m_hattribdc), the attribute device context.  
  
 By default, <CodeContentPlaceHolder>824\</CodeContentPlaceHolder> assumes the text for which it retrieves the dimension is set along a horizontal line (that is, the escapement is 0). If you create a font specifying a non-zero escapement, you must convert the angle of the text explicitly to get the dimensions of the string.  
  
 The current clipping region does not affect the width and height returned by <CodeContentPlaceHolder>825\</CodeContentPlaceHolder>.  
  
 Since some devices do not place characters in regular cell arrays (that is, they carry out kerning), the sum of the extents of the characters in a string may not be equal to the extent of the string.  
  
##  \<a name="cdc__gettextextentexpointi">\</a>  CDC::GetTextExtentExPointI  
 Retrieves the number of characters in a specified string that will fit within a specified space and fills an array with the text extent for each of those characters.  
  
<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>826\</CodeContentPlaceHolder>  
 A pointer to an array of glyph indices for which extents are to be retrieved.  
  
 <CodeContentPlaceHolder>827\</CodeContentPlaceHolder>  
 Specifies the number of glyphs in the array pointed to by <CodeContentPlaceHolder>828\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>829\</CodeContentPlaceHolder>  
 Specifies the maximum allowable width, in logical units, of the formatted string.  
  
 <CodeContentPlaceHolder>830\</CodeContentPlaceHolder>  
 A pointer to an integer that receives a count of the maximum number of characters that will fit in the space specified by <CodeContentPlaceHolder>831\</CodeContentPlaceHolder>. When <CodeContentPlaceHolder>832\</CodeContentPlaceHolder> is **NULL**, <CodeContentPlaceHolder>833\</CodeContentPlaceHolder> is ignored.  
  
 *alpDx*  
 A pointer to an array of integers that receives partial glyph extents. Each element in the array gives the distance, in logical units, between the beginning of the glyph indices array and one of the glyphs that fits in the space specified by <CodeContentPlaceHolder>834\</CodeContentPlaceHolder>. Although this array should have at least as many elements as glyph indices specified by <CodeContentPlaceHolder>835\</CodeContentPlaceHolder>, the function fills the array with extents only for as many glyph indices as are specified by <CodeContentPlaceHolder>836\</CodeContentPlaceHolder>. If                                 *lpnDx* is **NULL**, the function does not compute partial string widths.  
  
 <CodeContentPlaceHolder>837\</CodeContentPlaceHolder>  
 Pointer to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the dimensions of the glyph indices array, in logical units. This value cannot be **NULL**.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetTextExtentExPointI](http://msdn.microsoft.com/library/windows/desktop/dd144936), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__gettextextentpointi">\</a>  CDC::GetTextExtentPointI  
 Retrieves the width and height of the specified array of glyph indices.  
  
<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>838\</CodeContentPlaceHolder>  
 A pointer to an array of glyph indices for which extents are to be retrieved.  
  
 <CodeContentPlaceHolder>839\</CodeContentPlaceHolder>  
 Specifies the number of glyphs in the array pointed to by <CodeContentPlaceHolder>840\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>841\</CodeContentPlaceHolder>  
 Pointer to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure that receives the dimensions of the glyph indices array, in logical units. This value cannot be **NULL**.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This member function emulates the functionality of the function                         [GetTextExtentPointI](http://msdn.microsoft.com/library/windows/desktop/dd144939), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__gettextface">\</a>  CDC::GetTextFace  
 Call this member function to copy the typeface name of the current font into a buffer.  
  
<CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>842\</CodeContentPlaceHolder>  
 Specifies the size of the buffer (in bytes). If the typeface name is longer than the number of bytes specified by this parameter, the name is truncated.  
  
 *lpszFacename*  
 Points to the buffer for the typeface name.  
  
 <CodeContentPlaceHolder>843\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object.  
  
### Return Value  
 The number of bytes copied to the buffer, not including the terminating null character. It is 0 if an error occurs.  
  
### Remarks  
 The typeface name is copied as a null-terminated string.  
  
##  \<a name="cdc__gettextmetrics">\</a>  CDC::GetTextMetrics  
 Retrieves the metrics for the current font using the attribute device context.  
  
<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>844\</CodeContentPlaceHolder>  
 Points to the                                 [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure that receives the metrics.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
##  \<a name="cdc__getviewportext">\</a>  CDC::GetViewportExt  
 Retrieves the x- and y-extents of the device context's viewport.  
  
<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
### Return Value  
 The x- and y-extents (in device units) as a <CodeContentPlaceHolder>845\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__getviewportorg">\</a>  CDC::GetViewportOrg  
 Retrieves the x- and y-coordinates of the origin of the viewport associated with the device context.  
  
<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
### Return Value  
 The origin of the viewport (in device coordinates) as a <CodeContentPlaceHolder>846\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__getwindow">\</a>  CDC::GetWindow  
 Returns the window associated with the display device context.  
  
<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to a <CodeContentPlaceHolder>847\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 This is an advanced function. For example, this member function may not return the view window when printing or in print preview. It always returns the window associated with output. Output functions that use the given DC draw into this window.  
  
##  \<a name="cdc__getwindowext">\</a>  CDC::GetWindowExt  
 Retrieves the x- and y-extents of the window associated with the device context.  
  
<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
### Return Value  
 The x- and y-extents (in logical units) as a <CodeContentPlaceHolder>848\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__getwindoworg">\</a>  CDC::GetWindowOrg  
 Retrieves the x- and y-coordinates of the origin of the window associated with the device context.  
  
<CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
### Return Value  
 The origin of the window (in logical coordinates) as a <CodeContentPlaceHolder>849\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__getworldtransform">\</a>  CDC::GetWorldTransform  
 Retrieves the current world-space to page-space transformation.  
  
<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>850\</CodeContentPlaceHolder>  
 Reference to an                                 [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure that receives the current world-space to page-space transformation.  
  
### Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This method wraps the Windows GDI function                         [GetWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd144953).  
  
##  \<a name="cdc__gradientfill">\</a>  CDC::GradientFill  
 Call this member function to fill rectangle and triangle structures with color that smoothly fades from one side to the other.  
  
<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
### Parameters  
 *pVertices*  
 Pointer to an array of                                 [TRIVERTEX](http://msdn.microsoft.com/library/windows/desktop/dd145142) structures that each define a triangle vertex.  
  
 *nVertices*  
 The number of vertices.  
  
 <CodeContentPlaceHolder>851\</CodeContentPlaceHolder>  
 Array of                                 [GRADIENT_TRIANGLE](http://msdn.microsoft.com/library/windows/desktop/dd144959) structures in triangle mode, or an array of                                 [GRADIENT_RECT](http://msdn.microsoft.com/library/windows/desktop/dd144958) structures in rectangle mode.  
  
 *nMeshElements*  
 The number of elements (triangles or rectangles) in <CodeContentPlaceHolder>852\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>853\</CodeContentPlaceHolder>  
 Specifies gradient fill mode. For a list of possible values, see                                 [GradientFill](http://msdn.microsoft.com/library/windows/desktop/dd144957) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
### Remarks  
 For more information, see <CodeContentPlaceHolder>854\</CodeContentPlaceHolder> in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__graystring">\</a>  CDC::GrayString  
 Draws dimmed (gray) text at the given location by writing the text in a memory bitmap, dimming the bitmap, and then copying the bitmap to the display.  
  
<CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>855\</CodeContentPlaceHolder>  
 Identifies the brush to be used for dimming (graying).  
  
 <CodeContentPlaceHolder>856\</CodeContentPlaceHolder>  
 Specifies the procedure-instance address of the application-supplied callback function that will draw the string. For more information, see the description of the Windows **OutputFunc** [callback function](../vs140/callback-function-for-cdc--graystring.md). If this parameter is **NULL**, the system uses the Windows <CodeContentPlaceHolder>857\</CodeContentPlaceHolder> function to draw the string, and <CodeContentPlaceHolder>858\</CodeContentPlaceHolder> is assumed to be a long pointer to the character string to be output.  
  
 <CodeContentPlaceHolder>859\</CodeContentPlaceHolder>  
 Specifies a far pointer to data to be passed to the output function. If <CodeContentPlaceHolder>860\</CodeContentPlaceHolder> is **NULL**, <CodeContentPlaceHolder>861\</CodeContentPlaceHolder> must be a long pointer to the string to be output.  
  
 <CodeContentPlaceHolder>862\</CodeContentPlaceHolder>  
 Specifies the number of characters to be output. If this parameter is 0, <CodeContentPlaceHolder>863\</CodeContentPlaceHolder> calculates the length of the string (assuming that <CodeContentPlaceHolder>864\</CodeContentPlaceHolder> is a pointer to the string). If <CodeContentPlaceHolder>865\</CodeContentPlaceHolder> is –1 and the function pointed to by <CodeContentPlaceHolder>866\</CodeContentPlaceHolder> returns 0, the image is shown but not dimmed.  
  
 *x*  
 Specifies the logical x-coordinate of the starting position of the rectangle that encloses the string.  
  
 *y*  
 Specifies the logical y-coordinate of the starting position of the rectangle that encloses the string.  
  
 <CodeContentPlaceHolder>867\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the rectangle that encloses the string. If <CodeContentPlaceHolder>868\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>869\</CodeContentPlaceHolder> calculates the width of the area, assuming <CodeContentPlaceHolder>870\</CodeContentPlaceHolder> is a pointer to the string.  
  
 <CodeContentPlaceHolder>871\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the rectangle that encloses the string. If <CodeContentPlaceHolder>872\</CodeContentPlaceHolder> is 0, <CodeContentPlaceHolder>873\</CodeContentPlaceHolder> calculates the height of the area, assuming <CodeContentPlaceHolder>874\</CodeContentPlaceHolder> is a pointer to the string.  
  
### Return Value  
 Nonzero if the string is drawn, or 0 if either the <CodeContentPlaceHolder>875\</CodeContentPlaceHolder> function or the application-supplied output function returned 0, or if there was insufficient memory to create a memory bitmap for dimming.  
  
### Remarks  
 The function dims the text regardless of the selected brush and background. The <CodeContentPlaceHolder>876\</CodeContentPlaceHolder> member function uses the currently selected font. The <CodeContentPlaceHolder>877\</CodeContentPlaceHolder> mapping mode must be selected before using this function.  
  
 An application can draw dimmed (grayed) strings on devices that support a solid gray color without calling the <CodeContentPlaceHolder>878\</CodeContentPlaceHolder> member function. The system color **COLOR_GRAYTEXT** is the solid-gray system color used to draw disabled text. The application can call the **GetSysColor** Windows function to retrieve the color value of **COLOR_GRAYTEXT**. If the color is other than 0 (black), the application can call the <CodeContentPlaceHolder>879\</CodeContentPlaceHolder> member function to set the text color to the color value and then draw the string directly. If the retrieved color is black, the application must call <CodeContentPlaceHolder>880\</CodeContentPlaceHolder> to dim (gray) the text.  
  
 If <CodeContentPlaceHolder>881\</CodeContentPlaceHolder> is **NULL**, GDI uses the Windows                         [TextOut](http://msdn.microsoft.com/library/windows/desktop/dd145133) function, and <CodeContentPlaceHolder>882\</CodeContentPlaceHolder> is assumed to be a far pointer to the character to be output. If the characters to be output cannot be handled by the <CodeContentPlaceHolder>883\</CodeContentPlaceHolder> member function (for example, the string is stored as a bitmap), the application must supply its own output function.  
  
 Also note that all callback functions must trap Microsoft Foundation exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
 The callback function passed to <CodeContentPlaceHolder>884\</CodeContentPlaceHolder> must use the <CodeContentPlaceHolder>885\</CodeContentPlaceHolder> calling convention and must be exported with <CodeContentPlaceHolder>886\</CodeContentPlaceHolder>.  
  
 When the framework is in preview mode, a call to the <CodeContentPlaceHolder>887\</CodeContentPlaceHolder> member function is translated to a <CodeContentPlaceHolder>888\</CodeContentPlaceHolder> call, and the callback function is not called.  
  
##  \<a name="cdc__himetrictodp">\</a>  CDC::HIMETRICtoDP  
 Use this function when you convert **HIMETRIC** sizes from OLE to pixels.  
  
<CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>889\</CodeContentPlaceHolder>  
 Points to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 If the mapping mode of the device context object is <CodeContentPlaceHolder>890\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>891\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>892\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>893\</CodeContentPlaceHolder>, then the conversion is based on the number of pixels in the physical inch. If the mapping mode is one of the other non-constrained modes (e.g., <CodeContentPlaceHolder>894\</CodeContentPlaceHolder>), then the conversion is based on the number of pixels in the logical inch.  
  
##  \<a name="cdc__himetrictolp">\</a>  CDC::HIMETRICtoLP  
 Call this function to convert **HIMETRIC** units into logical units.  
  
<CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>895\</CodeContentPlaceHolder>  
 Points to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 Use this function when you get **HIMETRIC** sizes from OLE and wish to convert them to your application's natural mapping mode.  
  
 The conversion is accomplished by first converting the **HIMETRIC** units into pixels and then converting these units into logical units using the device context's current mapping units. Note that the extents of the device's window and viewport will affect the result.  
  
##  \<a name="cdc__intersectcliprect">\</a>  CDC::IntersectClipRect  
 Creates a new clipping region by forming the intersection of the current region and the rectangle specified by <CodeContentPlaceHolder>896\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>897\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>898\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>899\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>900\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>901\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>902\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>903\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>904\</CodeContentPlaceHolder>  
 Specifies the rectangle. You can pass either a <CodeContentPlaceHolder>905\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>906\</CodeContentPlaceHolder> structure for this parameter.  
  
### Return Value  
 The new clipping region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** New clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** New clipping region is empty.  
  
-   **SIMPLEREGION** New clipping region has no overlapping borders.  
  
### Remarks  
 GDI clips all subsequent output to fit within the new boundary. The width and height must not exceed 32,767.  
  
##  \<a name="cdc__invertrect">\</a>  CDC::InvertRect  
 Inverts the contents of the given rectangle.  
  
<CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>907\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>908\</CodeContentPlaceHolder> that contains the logical coordinates of the rectangle to be inverted. You can also pass a <CodeContentPlaceHolder>909\</CodeContentPlaceHolder> object for this parameter.  
  
### Remarks  
 Inversion is a logical NOT operation and flips the bits of each pixel. On monochrome displays, the function makes white pixels black and black pixels white. On color displays, the inversion depends on how colors are generated for the display. Calling <CodeContentPlaceHolder>910\</CodeContentPlaceHolder> twice with the same rectangle restores the display to its previous colors.  
  
 If the rectangle is empty, nothing is drawn.  
  
### Example  
 [!code[NVC_MFCDocView#36](../vs140/codesnippet/CPP/cdc-class_8.cpp)]  
  
##  \<a name="cdc__invertrgn">\</a>  CDC::InvertRgn  
 Inverts the colors in the region specified by <CodeContentPlaceHolder>911\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>912\</CodeContentPlaceHolder>  
 Identifies the region to be inverted. The coordinates for the region are specified in logical units.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 On monochrome displays, the function makes white pixels black and black pixels white. On color displays, the inversion depends on how the colors are generated for the display.  
  
##  \<a name="cdc__isprinting">\</a>  CDC::IsPrinting  
 Determines whether the device context is being used for printing.  
  
<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the <CodeContentPlaceHolder>913\</CodeContentPlaceHolder> object is a printer DC; otherwise 0.  
  
##  \<a name="cdc__lineto">\</a>  CDC::LineTo  
 Draws a line from the current position up to, but not including, the point specified by                 *x* and                 *y* (or <CodeContentPlaceHolder>914\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the endpoint for the line.  
  
 *y*  
 Specifies the logical y-coordinate of the endpoint for the line.  
  
 <CodeContentPlaceHolder>915\</CodeContentPlaceHolder>  
 Specifies the endpoint for the line. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>916\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the line is drawn; otherwise 0.  
  
### Remarks  
 The line is drawn with the selected pen. The current position is set to                         *x*,                        *y* or to <CodeContentPlaceHolder>917\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CRect::CenterPoint](../vs140/crect--centerpoint.md).  
  
##  \<a name="cdc__lptodp">\</a>  CDC::LPtoDP  
 Converts logical units into device units.  
  
<CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>918\</CodeContentPlaceHolder>  
 Points to an array of points. Each point in the array is a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object.  
  
 <CodeContentPlaceHolder>919\</CodeContentPlaceHolder>  
 The number of points in the array.  
  
 <CodeContentPlaceHolder>920\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object. This parameter is used for the common case of mapping a rectangle from logical to device units.  
  
 <CodeContentPlaceHolder>921\</CodeContentPlaceHolder>  
 Points to a                                 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or a [CSize](../vs140/csize-class.md) object.  
  
### Remarks  
 The function maps the coordinates of each point, or dimensions of a size, from GDI's logical coordinate system into a device coordinate system. The conversion depends on the current mapping mode and the settings of the origins and extents of the device's window and viewport.  
  
 The x- and y-coordinates of points are 2-byte signed integers in the range –32,768 through 32,767. In cases where the mapping mode would result in values larger than these limits, the system sets the values to –32,768 and 32,767, respectively.  
  
##  \<a name="cdc__lptohimetric">\</a>  CDC::LPtoHIMETRIC  
 Call this function to convert logical units into **HIMETRIC** units.  
  
<CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>922\</CodeContentPlaceHolder>  
 Points to a **SIZE** structure or a <CodeContentPlaceHolder>923\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Use this function when you give **HIMETRIC** sizes to OLE, converting from your application's natural mapping mode. Note that the extents of the device's window and viewport will affect the result.  
  
 The conversion is accomplished by first converting the logical units into pixels using the device context's current mapping units and then converting these units into **HIMETRIC** units.  
  
##  \<a name="cdc__m_hattribdc">\</a>  CDC::m_hAttribDC  
 The attribute device context for this <CodeContentPlaceHolder>924\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
### Remarks  
 By default, this device context is equal to <CodeContentPlaceHolder>925\</CodeContentPlaceHolder>. In general, <CodeContentPlaceHolder>926\</CodeContentPlaceHolder> GDI calls that request information from the device context are directed to <CodeContentPlaceHolder>927\</CodeContentPlaceHolder>. See the [CDC](../vs140/cdc-class.md) class description for more on the use of these two device contexts.  
  
##  \<a name="cdc__m_hdc">\</a>  CDC::m_hDC  
 The output device context for this <CodeContentPlaceHolder>928\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
### Remarks  
 By default, <CodeContentPlaceHolder>929\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>930\</CodeContentPlaceHolder>, the other device context wrapped by <CodeContentPlaceHolder>931\</CodeContentPlaceHolder>. In general, <CodeContentPlaceHolder>932\</CodeContentPlaceHolder> GDI calls that create output go to the <CodeContentPlaceHolder>933\</CodeContentPlaceHolder> device context. You can initialize <CodeContentPlaceHolder>934\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>935\</CodeContentPlaceHolder> to point to different devices. See the [CDC](../vs140/cdc-class.md) class description for more on the use of these two device contexts.  
  
##  \<a name="cdc__maskblt">\</a>  CDC::MaskBlt  
 Combines the color data for the source and destination bitmaps using the given mask and raster operation.  
  
<CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>936\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>937\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>938\</CodeContentPlaceHolder>  
 Identifies the device context from which the bitmap is to be copied. It must be zero if the                                 *dwRop* parameter specifies a raster operation that does not include a source.  
  
 <CodeContentPlaceHolder>939\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>940\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>941\</CodeContentPlaceHolder>  
 Identifies the monochrome mask bitmap combined with the color bitmap in the source device context.  
  
 <CodeContentPlaceHolder>942\</CodeContentPlaceHolder>  
 Specifies the horizontal pixel offset for the mask bitmap specified by the <CodeContentPlaceHolder>943\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>944\</CodeContentPlaceHolder>  
 Specifies the vertical pixel offset for the mask bitmap specified by the <CodeContentPlaceHolder>945\</CodeContentPlaceHolder> parameter.  
  
 *dwRop*  
 Specifies both foreground and background ternary raster operation codes, which the function uses to control the combination of source and destination data. The background raster operation code is stored in the high byte of the high word of this value; the foreground raster operation code is stored in the low byte of the high word of this value; the low word of this value is ignored, and should be zero. The macro **MAKEROP4** creates such combinations of foreground and background raster operation codes. See the Remarks section for a discussion of foreground and background in the context of this function. See the <CodeContentPlaceHolder>946\</CodeContentPlaceHolder> member function for a list of common raster operation codes.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 A value of 1 in the mask specified by <CodeContentPlaceHolder>947\</CodeContentPlaceHolder> indicates that the foreground raster operation code specified by                         *dwRop* should be applied at that location. A value of 0 in the mask indicates that the background raster operation code specified by                         *dwRop* should be applied at that location. If the raster operations require a source, the mask rectangle must cover the source rectangle. If it does not, the function will fail. If the raster operations do not require a source, the mask rectangle must cover the destination rectangle. If it does not, the function will fail.  
  
 If a rotation or shear transformation is in effect for the source device context when this function is called, an error occurs. However, other types of transformations are allowed.  
  
 If the color formats of the source, pattern, and destination bitmaps differ, this function converts the pattern or source format, or both, to match the destination format. If the mask bitmap is not a monochrome bitmap, an error occurs. When an enhanced metafile is being recorded, an error occurs (and the function returns 0) if the source device context identifies an enhanced-metafile device context. Not all devices support <CodeContentPlaceHolder>948\</CodeContentPlaceHolder>. An application should call <CodeContentPlaceHolder>949\</CodeContentPlaceHolder> to determine whether a device supports this function. If no mask bitmap is supplied, this function behaves exactly like <CodeContentPlaceHolder>950\</CodeContentPlaceHolder>, using the foreground raster operation code. The pixel offsets in the mask bitmap map to the point (0,0) in the source device context's bitmap. This is useful for cases in which a mask bitmap contains a set of masks; an application can easily apply any one of them to a mask-blitting task by adjusting the pixel offsets and rectangle sizes sent to <CodeContentPlaceHolder>951\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__modifyworldtransform">\</a>  CDC::ModifyWorldTransform  
 Changes the world transformation for a device context using the specified mode.  
  
<CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>952\</CodeContentPlaceHolder>  
 Reference to an                                 [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure used to modify the world transformation for the given device context.  
  
 <CodeContentPlaceHolder>953\</CodeContentPlaceHolder>  
 Specifies how the transformation data modifies the current world transformation. For a list of the values that this parameter can take, see                                 [ModifyWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145060).  
  
### Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This method wraps the Windows GDI function                         [ModifyWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145060).  
  
##  \<a name="cdc__moveto">\</a>  CDC::MoveTo  
 Moves the current position to the point specified by                 *x* and                 *y* (or by <CodeContentPlaceHolder>954\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the new position.  
  
 *y*  
 Specifies the logical y-coordinate of the new position.  
  
 <CodeContentPlaceHolder>955\</CodeContentPlaceHolder>  
 Specifies the new position. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>956\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 The x- and y-coordinates of the previous position as a <CodeContentPlaceHolder>957\</CodeContentPlaceHolder> object.  
  
### Example  
  See the example for [CRect::CenterPoint](../vs140/crect--centerpoint.md).  
  
##  \<a name="cdc__offsetcliprgn">\</a>  CDC::OffsetClipRgn  
 Moves the clipping region of the device context by the specified offsets.  
  
<CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the number of logical units to move left or right.  
  
 *y*  
 Specifies the number of logical units to move up or down.  
  
 <CodeContentPlaceHolder>958\</CodeContentPlaceHolder>  
 Specifies the amount to offset.  
  
### Return Value  
 The new region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** Clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** Clipping region is empty.  
  
-   **SIMPLEREGION** Clipping region has no overlapping borders.  
  
### Remarks  
 The function moves the region                         *x* units along the x-axis and                         *y* units along the y-axis.  
  
##  \<a name="cdc__offsetviewportorg">\</a>  CDC::OffsetViewportOrg  
 Modifies the coordinates of the viewport origin relative to the coordinates of the current viewport origin.  
  
<CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>959\</CodeContentPlaceHolder>  
 Specifies the number of device units to add to the current origin's x-coordinate.  
  
 <CodeContentPlaceHolder>960\</CodeContentPlaceHolder>  
 Specifies the number of device units to add to the current origin's y-coordinate.  
  
### Return Value  
 The previous viewport origin (in device coordinates) as a <CodeContentPlaceHolder>961\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__offsetwindoworg">\</a>  CDC::OffsetWindowOrg  
 Modifies the coordinates of the window origin relative to the coordinates of the current window origin.  
  
<CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>962\</CodeContentPlaceHolder>  
 Specifies the number of logical units to add to the current origin's x-coordinate.  
  
 <CodeContentPlaceHolder>963\</CodeContentPlaceHolder>  
 Specifies the number of logical units to add to the current origin's y-coordinate.  
  
### Return Value  
 The previous window origin (in logical coordinates) as a <CodeContentPlaceHolder>964\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__operator_hdc">\</a>  CDC::operator HDC  
 Use this operator to retrieve the device context handle of the <CodeContentPlaceHolder>965\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
### Return Value  
 If successful, the handle of the device context object; otherwise, **NULL**.  
  
### Remarks  
 You can use the handle to call Windows APIs directly.  
  
##  \<a name="cdc__paintrgn">\</a>  CDC::PaintRgn  
 Fills the region specified by <CodeContentPlaceHolder>966\</CodeContentPlaceHolder> using the current brush.  
  
<CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>967\</CodeContentPlaceHolder>  
 Identifies the region to be filled. The coordinates for the given region are specified in logical units.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
##  \<a name="cdc__patblt">\</a>  CDC::PatBlt  
 Creates a bit pattern on the device.  
  
<CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle that is to receive the pattern.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle that is to receive the pattern.  
  
 <CodeContentPlaceHolder>968\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the rectangle that is to receive the pattern.  
  
 <CodeContentPlaceHolder>969\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the rectangle that is to receive the pattern.  
  
 *dwRop*  
 Specifies the raster-operation code. Raster-operation codes (ROPs) define how GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. This parameter can be one of the following values:  
  
-   **PATCOPY** Copies pattern to destination bitmap.  
  
-   **PATINVERT** Combines destination bitmap with pattern using the Boolean XOR operator.  
  
-   **DSTINVERT** Inverts the destination bitmap.  
  
-   **BLACKNESS** Turns all output black.  
  
-   **WHITENESS** Turns all output white.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The pattern is a combination of the selected brush and the pattern already on the device. The raster-operation code specified by                         *dwRop* defines how the patterns are to be combined. The raster operations listed for this function are a limited subset of the full 256 ternary raster-operation codes; in particular, a raster-operation code that refers to a source cannot be used.  
  
 Not all device contexts support the <CodeContentPlaceHolder>970\</CodeContentPlaceHolder> function. To determine whether a device context supports <CodeContentPlaceHolder>971\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>972\</CodeContentPlaceHolder> member function with the **RASTERCAPS** index and check the return value for the **RC_BITBLT** flag.  
  
##  \<a name="cdc__pie">\</a>  CDC::Pie  
 Draws a pie-shaped wedge by drawing an elliptical arc whose center and two endpoints are joined by lines.  
  
<CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>973\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>974\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>975\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 <CodeContentPlaceHolder>976\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the bounding rectangle (in logical units).  
  
 *x3*  
 Specifies the x-coordinate of the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>977\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the arc's starting point (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>978\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>979\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the arc's endpoint (in logical units). This point does not have to lie exactly on the arc.  
  
 <CodeContentPlaceHolder>980\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle. You can pass either a <CodeContentPlaceHolder>981\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>982\</CodeContentPlaceHolder> structure for this parameter.  
  
 <CodeContentPlaceHolder>983\</CodeContentPlaceHolder>  
 Specifies the starting point of the arc. This point does not have to lie exactly on the arc. You can pass either a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>984\</CodeContentPlaceHolder>  
 Specifies the endpoint of the arc. This point does not have to lie exactly on the arc. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>985\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The center of the arc is the center of the bounding rectangle specified by <CodeContentPlaceHolder>986\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>987\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>988\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>989\</CodeContentPlaceHolder> (or by <CodeContentPlaceHolder>990\</CodeContentPlaceHolder>). The starting and ending points of the arc are specified by                         *x3*, <CodeContentPlaceHolder>991\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>992\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>993\</CodeContentPlaceHolder> (or by <CodeContentPlaceHolder>994\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>995\</CodeContentPlaceHolder>).  
  
 The arc is drawn with the selected pen, moving in a counterclockwise direction. Two additional lines are drawn from each endpoint to the arc's center. The pie-shaped area is filled with the current brush. If                         *x3* equals <CodeContentPlaceHolder>996\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>997\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>998\</CodeContentPlaceHolder>, the result is an ellipse with a single line from the center of the ellipse to the point (                        *x3*, <CodeContentPlaceHolder>999\</CodeContentPlaceHolder>) or ( <CodeContentPlaceHolder>1000\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1001\</CodeContentPlaceHolder>).  
  
 The figure drawn by this function extends up to but does not include the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>1002\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1003\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>1004\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1005\</CodeContentPlaceHolder>. Both the width and the height of the bounding rectangle must be greater than 2 units and less than 32,767 units.  
  
### Example  
 [!code[NVC_MFCDocView#37](../vs140/codesnippet/CPP/cdc-class_9.cpp)]  
  
##  \<a name="cdc__playmetafile">\</a>  CDC::PlayMetaFile  
 Plays the contents of the specified metafile on the device context.  
  
<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
### Parameters  
 *hMF*  
 Identifies the metafile to be played.  
  
 *hEnhMetaFile*  
 Identifies the enhanced metafile.  
  
 <CodeContentPlaceHolder>1006\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>1007\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>1008\</CodeContentPlaceHolder> object that contains the coordinates of the bounding rectangle used to display the picture. The coordinates are specified in logical units.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The metafile can be played any number of times.  
  
 The second version of <CodeContentPlaceHolder>1009\</CodeContentPlaceHolder> displays the picture stored in the given enhanced-format metafile. When an application calls the second version of <CodeContentPlaceHolder>1010\</CodeContentPlaceHolder>, Windows uses the picture frame in the enhanced-metafile header to map the picture onto the rectangle pointed to by the <CodeContentPlaceHolder>1011\</CodeContentPlaceHolder> parameter. (This picture may be sheared or rotated by setting the world transform in the output device before calling <CodeContentPlaceHolder>1012\</CodeContentPlaceHolder>.) Points along the edges of the rectangle are included in the picture. An enhanced-metafile picture can be clipped by defining the clipping region in the output device before playing the enhanced metafile.  
  
 If an enhanced metafile contains an optional palette, an application can achieve consistent colors by setting up a color palette on the output device before calling the second version of <CodeContentPlaceHolder>1013\</CodeContentPlaceHolder>. To retrieve the optional palette, use the **GetEnhMetaFilePaletteEntries** Windows function. An enhanced metafile can be embedded in a newly created enhanced metafile by calling the second version of <CodeContentPlaceHolder>1014\</CodeContentPlaceHolder> and playing the source enhanced metafile into the device context for the new enhanced metafile.  
  
 The states of the output device context are preserved by this function. Any object created but not deleted in the enhanced metafile is deleted by this function. To stop this function, an application can call the **CancelDC** Windows function from another thread to terminate the operation. In this case, the function returns zero.  
  
##  \<a name="cdc__plgblt">\</a>  CDC::PlgBlt  
 Performs a bit-block transfer of the bits of color data from the specified rectangle in the source device context to the specified parallelogram in the given device context.  
  
<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1015\</CodeContentPlaceHolder>  
 Points to an array of three points in logical space that identifies three corners of the destination parallelogram. The upper-left corner of the source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower-left corner to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.  
  
 <CodeContentPlaceHolder>1016\</CodeContentPlaceHolder>  
 Identifies the source device context.  
  
 <CodeContentPlaceHolder>1017\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>1018\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>1019\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1020\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1021\</CodeContentPlaceHolder>  
 Identifies an optional monochrome bitmap that is used to mask the colors of the source rectangle.  
  
 <CodeContentPlaceHolder>1022\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the monochrome bitmap.  
  
 <CodeContentPlaceHolder>1023\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the monochrome bitmap.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 If the given bitmask handle identifies a valid monochrome bitmap, the function uses this bitmap to mask the bits of color data from the source rectangle.  
  
 The fourth vertex of the parallelogram (D) is defined by treating the first three points (A, B, and C) as vectors and computing D = B + C - A.  
  
 If the bitmask exists, a value of 1 in the mask indicates that the source pixel color should be copied to the destination. A value of 0 in the mask indicates that the destination pixel color is not to be changed.  
  
 If the mask rectangle is smaller than the source and destination rectangles, the function replicates the mask pattern.  
  
 Scaling, translation, and reflection transformations are allowed in the source device context; however, rotation and shear transformations are not. If the mask bitmap is not a monochrome bitmap, an error occurs. The stretching mode for the destination device context is used to determine how to stretch or compress the pixels, if that is necessary. When an enhanced metafile is being recorded, an error occurs if the source device context identifies an enhanced-metafile device context.  
  
 The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to the source device context. If the source transformation has a rotation or shear, an error is returned. If the destination and source rectangles do not have the same color format, <CodeContentPlaceHolder>1024\</CodeContentPlaceHolder> converts the source rectangle to match the destination rectangle. Not all devices support <CodeContentPlaceHolder>1025\</CodeContentPlaceHolder>. For more information, see the description of the **RC_BITBLT** raster capability in the <CodeContentPlaceHolder>1026\</CodeContentPlaceHolder> member function.  
  
 If the source and destination device contexts represent incompatible devices, <CodeContentPlaceHolder>1027\</CodeContentPlaceHolder> returns an error.  
  
##  \<a name="cdc__polybezier">\</a>  CDC::PolyBezier  
 Draws one or more Bzier splines.  
  
<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1028\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contain the endpoints and control points of the spline(s).  
  
 <CodeContentPlaceHolder>1029\</CodeContentPlaceHolder>  
 Specifies the number of points in the <CodeContentPlaceHolder>1030\</CodeContentPlaceHolder> array. This value must be one more than three times the number of splines to be drawn, because each Bzier spline requires two control points and an endpoint, and the initial spline requires an additional starting point.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This function draws cubic Bzier splines by using the endpoints and control points specified by the <CodeContentPlaceHolder>1031\</CodeContentPlaceHolder> parameter. The first spline is drawn from the first point to the fourth point by using the second and third points as control points. Each subsequent spline in the sequence needs exactly three more points: the end point of the previous spline is used as the starting point, the next two points in the sequence are control points, and the third is the end point.  
  
 The current position is neither used nor updated by the <CodeContentPlaceHolder>1032\</CodeContentPlaceHolder> function. The figure is not filled. This function draws lines by using the current pen.  
  
##  \<a name="cdc__polybezierto">\</a>  CDC::PolyBezierTo  
 Draws one or more Bzier splines.  
  
<CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1033\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contains the endpoints and control points.  
  
 <CodeContentPlaceHolder>1034\</CodeContentPlaceHolder>  
 Specifies the number of points in the <CodeContentPlaceHolder>1035\</CodeContentPlaceHolder> array. This value must be three times the number of splines to be drawn, because each Bzier spline requires two control points and an end point.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This function draws cubic Bzier splines by using the control points specified by the <CodeContentPlaceHolder>1036\</CodeContentPlaceHolder> parameter. The first spline is drawn from the current position to the third point by using the first two points as control points. For each subsequent spline, the function needs exactly three more points, and uses the end point of the previous spline as the starting point for the next. <CodeContentPlaceHolder>1037\</CodeContentPlaceHolder> moves the current position to the end point of the last Bzier spline. The figure is not filled. This function draws lines by using the current pen.  
  
### Example  
  See the example for [CDC::BeginPath](#cdc__beginpath).  
  
##  \<a name="cdc__polydraw">\</a>  CDC::PolyDraw  
 Draws a set of line segments and Bzier splines.  
  
<CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1038\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contains the endpoints for each line segment and the endpoints and control points for each Bzier spline.  
  
 <CodeContentPlaceHolder>1039\</CodeContentPlaceHolder>  
 Points to an array that specifies how each point in the <CodeContentPlaceHolder>1040\</CodeContentPlaceHolder> array is used. Values can be one of the following:  
  
-   **PT_MOVETO** Specifies that this point starts a disjoint figure. This point becomes the new current position.  
  
-   **PT_LINETO** Specifies that a line is to be drawn from the current position to this point, which then becomes the new current position.  
  
-   **PT_BEZIERTO** Specifies that this point is a control point or ending point for a Bzier spline.  
  
     **PT_BEZIERTO** types always occur in sets of three. The current position defines the starting point for the Bzier spline. The first two **PT_BEZIERTO** points are the control points, and the third **PT_BEZIERTO** point is the ending point. The ending point becomes the new current position. If there are not three consecutive **PT_BEZIERTO** points, an error results.  
  
     A **PT_LINETO** or **PT_BEZIERTO** type can be combined with the following constant by using the bitwise operator OR to indicate that the corresponding point is the last point in a figure and the figure is closed:  
  
-   **PT_CLOSEFIGURE** Specifies that the figure is automatically closed after the **PT_LINETO** or **PT_BEZIERTO** type for this point is done. A line is drawn from this point to the most recent **PT_MOVETO** or <CodeContentPlaceHolder>1041\</CodeContentPlaceHolder> point.  
  
     This flag is combined with the **PT_LINETO** type for a line, or with the **PT_BEZIERTO** type of ending point for a Bzier spline, by using the bitwise <CodeContentPlaceHolder>1042\</CodeContentPlaceHolder> operator. The current position is set to the ending point of the closing line.  
  
 <CodeContentPlaceHolder>1043\</CodeContentPlaceHolder>  
 Specifies the total number of points in the <CodeContentPlaceHolder>1044\</CodeContentPlaceHolder> array, the same as the number of bytes in the <CodeContentPlaceHolder>1045\</CodeContentPlaceHolder> array.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This function can be used to draw disjoint figures in place of consecutive calls to <CodeContentPlaceHolder>1046\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1047\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>1048\</CodeContentPlaceHolder> member functions. The lines and splines are drawn using the current pen, and figures are not filled. If there is an active path started by calling the <CodeContentPlaceHolder>1049\</CodeContentPlaceHolder> member function, <CodeContentPlaceHolder>1050\</CodeContentPlaceHolder> adds to the path. The points contained in the <CodeContentPlaceHolder>1051\</CodeContentPlaceHolder> array and in <CodeContentPlaceHolder>1052\</CodeContentPlaceHolder> indicate whether each point is part of a <CodeContentPlaceHolder>1053\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>1054\</CodeContentPlaceHolder>, or a **CDC::BezierTo** operation. It is also possible to close figures. This function updates the current position.  
  
### Example  
  See the example for [CDC::BeginPath](#cdc__beginpath).  
  
##  \<a name="cdc__polygon">\</a>  CDC::Polygon  
 Draws a polygon consisting of two or more points (vertices) connected by lines, using the current pen.  
  
<CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1055\</CodeContentPlaceHolder>  
 Points to an array of points that specifies the vertices of the polygon. Each point in the array is a **POINT** structure or a <CodeContentPlaceHolder>1056\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>1057\</CodeContentPlaceHolder>  
 Specifies the number of vertices in the array.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The system closes the polygon automatically, if necessary, by drawing a line from the last vertex to the first.  
  
 The current polygon-filling mode can be retrieved or set by using the <CodeContentPlaceHolder>1058\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1059\</CodeContentPlaceHolder> member functions.  
  
### Example  
 [!code[NVC_MFCDocView#38](../vs140/codesnippet/CPP/cdc-class_10.cpp)]  
  
##  \<a name="cdc__polyline">\</a>  CDC::Polyline  
 Draws a set of line segments connecting the points specified by <CodeContentPlaceHolder>1060\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1061\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or <CodeContentPlaceHolder>1062\</CodeContentPlaceHolder> objects to be connected.  
  
 <CodeContentPlaceHolder>1063\</CodeContentPlaceHolder>  
 Specifies the number of points in the array. This value must be at least 2.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The lines are drawn from the first point through subsequent points using the current pen. Unlike the <CodeContentPlaceHolder>1064\</CodeContentPlaceHolder> member function, the <CodeContentPlaceHolder>1065\</CodeContentPlaceHolder> function neither uses nor updates the current position.  
  
 For more information, see                         [PolyLine](http://msdn.microsoft.com/library/windows/desktop/dd162815) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__polylineto">\</a>  CDC::PolylineTo  
 Draws one or more straight lines.  
  
<CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1066\</CodeContentPlaceHolder>  
 Points to an array of [POINT](../vs140/point-structure.md) data structures that contains the vertices of the line.  
  
 <CodeContentPlaceHolder>1067\</CodeContentPlaceHolder>  
 Specifies the number of points in the array.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 A line is drawn from the current position to the first point specified by the <CodeContentPlaceHolder>1068\</CodeContentPlaceHolder> parameter by using the current pen. For each additional line, the function draws from the ending point of the previous line to the next point specified by <CodeContentPlaceHolder>1069\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>1070\</CodeContentPlaceHolder> moves the current position to the ending point of the last line. If the line segments drawn by this function form a closed figure, the figure is not filled.  
  
##  \<a name="cdc__polypolygon">\</a>  CDC::PolyPolygon  
 Creates two or more polygons that are filled using the current polygon-filling mode.  
  
<CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1071\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or <CodeContentPlaceHolder>1072\</CodeContentPlaceHolder> objects that define the vertices of the polygons.  
  
 <CodeContentPlaceHolder>1073\</CodeContentPlaceHolder>  
 Points to an array of integers, each of which specifies the number of points in one of the polygons in the <CodeContentPlaceHolder>1074\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>1075\</CodeContentPlaceHolder>  
 The number of entries in the <CodeContentPlaceHolder>1076\</CodeContentPlaceHolder> array. This number specifies the number of polygons to be drawn. This value must be at least 2.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The polygons may be disjoint or overlapping.  
  
 Each polygon specified in a call to the <CodeContentPlaceHolder>1077\</CodeContentPlaceHolder> function must be closed. Unlike polygons created by the **Polygon** member function, the polygons created by <CodeContentPlaceHolder>1078\</CodeContentPlaceHolder> are not closed automatically.  
  
 The function creates two or more polygons. To create a single polygon, an application should use the **Polygon** member function.  
  
 The current polygon-filling mode can be retrieved or set by using the <CodeContentPlaceHolder>1079\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1080\</CodeContentPlaceHolder> member functions.  
  
##  \<a name="cdc__polypolyline">\</a>  CDC::PolyPolyline  
 Draws multiple series of connected line segments.  
  
<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1081\</CodeContentPlaceHolder>  
 Points to an array of structures that contains the vertices of the polylines. The polylines are specified consecutively.  
  
 <CodeContentPlaceHolder>1082\</CodeContentPlaceHolder>  
 Points to an array of variables specifying the number of points in the <CodeContentPlaceHolder>1083\</CodeContentPlaceHolder> array for the corresponding polygon. Each entry must be greater than or equal to 2.  
  
 <CodeContentPlaceHolder>1084\</CodeContentPlaceHolder>  
 Specifies the total number of counts in the <CodeContentPlaceHolder>1085\</CodeContentPlaceHolder> array.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The line segments are drawn by using the current pen. The figures formed by the segments are not filled. The current position is neither used nor updated by this function.  
  
##  \<a name="cdc__ptvisible">\</a>  CDC::PtVisible  
 Determines whether the given point is within the clipping region of the device context.  
  
<CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point.  
  
 *y*  
 Specifies the logical y-coordinate of the point.  
  
 <CodeContentPlaceHolder>1086\</CodeContentPlaceHolder>  
 Specifies the point to check in logical coordinates. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1087\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the specified point is within the clipping region; otherwise 0.  
  
##  \<a name="cdc__queryabort">\</a>  CDC::QueryAbort  
 Calls the abort function installed by the [SetAbortProc](#cdc__setabortproc) member function for a printing application and queries whether the printing should be terminated.  
  
<CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
### Return Value  
 The return value is nonzero if printing should continue or if there is no abort procedure. It is 0 if the print job should be terminated. The return value is supplied by the abort function.  
  
##  \<a name="cdc__realizepalette">\</a>  CDC::RealizePalette  
 Maps entries from the current logical palette to the system palette.  
  
<CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
### Return Value  
 Indicates how many entries in the logical palette were mapped to different entries in the system palette. This represents the number of entries that this function remapped to accommodate changes in the system palette since the logical palette was last realized.  
  
### Remarks  
 A logical color palette acts as a buffer between color-intensive applications and the system, allowing an application to use as many colors as needed without interfering with its own displayed colors or with colors displayed by other windows.  
  
 When a window has the input focus and calls <CodeContentPlaceHolder>1088\</CodeContentPlaceHolder>, Windows ensures that the window will display all the requested colors, up to the maximum number simultaneously available on the screen. Windows also displays colors not found in the window's palette by matching them to available colors.  
  
 In addition, Windows matches the colors requested by inactive windows that call the function as closely as possible to the available colors. This significantly reduces undesirable changes in the colors displayed in inactive windows.  
  
##  \<a name="cdc__rectangle">\</a>  CDC::Rectangle  
 Draws a rectangle using the current pen.  
  
<CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1089\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1090\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1091\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1092\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1093\</CodeContentPlaceHolder>  
 Specifies the rectangle in logical units. You can pass either a <CodeContentPlaceHolder>1094\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>1095\</CodeContentPlaceHolder> structure for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The interior of the rectangle is filled using the current brush.  
  
 The rectangle extends up to, but does not include, the right and bottom coordinates. This means that the height of the rectangle is <CodeContentPlaceHolder>1096\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1097\</CodeContentPlaceHolder> and the width of the rectangle is <CodeContentPlaceHolder>1098\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1099\</CodeContentPlaceHolder>. Both the width and the height of a rectangle must be greater than 2 units and less than 32,767 units.  
  
### Example  
 [!code[NVC_MFCDocView#39](../vs140/codesnippet/CPP/cdc-class_11.cpp)]  
  
##  \<a name="cdc__rectvisible">\</a>  CDC::RectVisible  
 Determines whether any part of the given rectangle lies within the clipping region of the display context.  
  
<CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1100\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>1101\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>1102\</CodeContentPlaceHolder> object that contains the logical coordinates of the specified rectangle.  
  
### Return Value  
 Nonzero if any portion of the given rectangle lies within the clipping region; otherwise 0.  
  
##  \<a name="cdc__releaseattribdc">\</a>  CDC::ReleaseAttribDC  
 Call this member function to set <CodeContentPlaceHolder>1103\</CodeContentPlaceHolder> to **NULL**.  
  
<CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
### Remarks  
 This does not cause a **Detach** to occur. Only the output device context is attached to the <CodeContentPlaceHolder>1104\</CodeContentPlaceHolder> object, and only it can be detached.  
  
##  \<a name="cdc__releaseoutputdc">\</a>  CDC::ReleaseOutputDC  
 Call this member function to set the <CodeContentPlaceHolder>1105\</CodeContentPlaceHolder> member to **NULL**.  
  
<CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
### Remarks  
 This member function cannot be called when the output device context is attached to the <CodeContentPlaceHolder>1106\</CodeContentPlaceHolder> object. Use the **Detach** member function to detach the output device context.  
  
##  \<a name="cdc__resetdc">\</a>  CDC::ResetDC  
 Call this member function to update the device context wrapped by the <CodeContentPlaceHolder>1107\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
### Parameters  
 *lpDevMode*  
 A pointer to a Windows <CodeContentPlaceHolder>1108\</CodeContentPlaceHolder> structure.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The device context is updated from the information specified in the Windows <CodeContentPlaceHolder>1109\</CodeContentPlaceHolder> structure. This member function only resets the attribute device context.  
  
 An application will typically use the <CodeContentPlaceHolder>1110\</CodeContentPlaceHolder> member function when a window processes a <CodeContentPlaceHolder>1111\</CodeContentPlaceHolder> message. You can also use this member function to change the paper orientation or paper bins while printing a document.  
  
 You cannot use this member function to change the driver name, device name, or output port. When the user changes the port connection or device name, you must delete the original device context and create a new device context with the new information.  
  
 Before you call this member function, you must ensure that all objects (other than stock objects) that had been selected into the device context have been selected out.  
  
##  \<a name="cdc__restoredc">\</a>  CDC::RestoreDC  
 Restores the device context to the previous state identified by <CodeContentPlaceHolder>1112\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1113\</CodeContentPlaceHolder>  
 Specifies the device context to be restored. It can be a value returned by a previous <CodeContentPlaceHolder>1114\</CodeContentPlaceHolder> function call. If <CodeContentPlaceHolder>1115\</CodeContentPlaceHolder> is –1, the most recently saved device context is restored.  
  
### Return Value  
 Nonzero if the specified context was restored; otherwise 0.  
  
### Remarks  
 <CodeContentPlaceHolder>1116\</CodeContentPlaceHolder> restores the device context by popping state information off a stack created by earlier calls to the <CodeContentPlaceHolder>1117\</CodeContentPlaceHolder> member function.  
  
 The stack can contain the state information for several device contexts. If the context specified by <CodeContentPlaceHolder>1118\</CodeContentPlaceHolder> is not at the top of the stack, <CodeContentPlaceHolder>1119\</CodeContentPlaceHolder> deletes all state information between the device context specified by <CodeContentPlaceHolder>1120\</CodeContentPlaceHolder> and the top of the stack. The deleted information is lost.  
  
##  \<a name="cdc__roundrect">\</a>  CDC::RoundRect  
 Draws a rectangle with rounded corners using the current pen.  
  
<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1121\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1122\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1123\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 <CodeContentPlaceHolder>1124\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the rectangle (in logical units).  
  
 *x3*  
 Specifies the width of the ellipse used to draw the rounded corners (in logical units).  
  
 <CodeContentPlaceHolder>1125\</CodeContentPlaceHolder>  
 Specifies the height of the ellipse used to draw the rounded corners (in logical units).  
  
 <CodeContentPlaceHolder>1126\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle in logical units. You can pass either a <CodeContentPlaceHolder>1127\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>1128\</CodeContentPlaceHolder> structure for this parameter.  
  
 <CodeContentPlaceHolder>1129\</CodeContentPlaceHolder>  
 The x-coordinate of <CodeContentPlaceHolder>1130\</CodeContentPlaceHolder> specifies the width of the ellipse to draw the rounded corners (in logical units). The y-coordinate of <CodeContentPlaceHolder>1131\</CodeContentPlaceHolder> specifies the height of the ellipse to draw the rounded corners (in logical units). You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1132\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The interior of the rectangle is filled using the current brush.  
  
 The figure this function draws extends up to but does not include the right and bottom coordinates. This means that the height of the figure is <CodeContentPlaceHolder>1133\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1134\</CodeContentPlaceHolder> and the width of the figure is <CodeContentPlaceHolder>1135\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>1136\</CodeContentPlaceHolder>. Both the height and the width of the bounding rectangle must be greater than 2 units and less than 32,767 units.  
  
### Example  
 [!code[NVC_MFCDocView#40](../vs140/codesnippet/CPP/cdc-class_12.cpp)]  
  
##  \<a name="cdc__savedc">\</a>  CDC::SaveDC  
 Saves the current state of the device context by copying state information (such as clipping region, selected objects, and mapping mode) to a context stack maintained by Windows.  
  
<CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
### Return Value  
 An integer identifying the saved device context. It is 0 if an error occurs. This return value can be used to restore the device context by calling <CodeContentPlaceHolder>1137\</CodeContentPlaceHolder>.  
  
### Remarks  
 The saved device context can later be restored by using <CodeContentPlaceHolder>1138\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>1139\</CodeContentPlaceHolder> can be used any number of times to save any number of device-context states.  
  
##  \<a name="cdc__scaleviewportext">\</a>  CDC::ScaleViewportExt  
 Modifies the viewport extents relative to the current values.  
  
<CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1140\</CodeContentPlaceHolder>  
 Specifies the amount by which to multiply the current x-extent.  
  
 <CodeContentPlaceHolder>1141\</CodeContentPlaceHolder>  
 Specifies the amount by which to divide the result of multiplying the current x-extent by the value of the <CodeContentPlaceHolder>1142\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>1143\</CodeContentPlaceHolder>  
 Specifies the amount by which to multiply the current y-extent.  
  
 <CodeContentPlaceHolder>1144\</CodeContentPlaceHolder>  
 Specifies the amount by which to divide the result of multiplying the current y-extent by the value of the <CodeContentPlaceHolder>1145\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 The previous viewport extents (in device units) as a <CodeContentPlaceHolder>1146\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The formulas are written as follows:  
  
 <CodeContentPlaceHolder>1147\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>1148\</CodeContentPlaceHolder>  
  
 The new viewport extents are calculated by multiplying the current extents by the given numerator and then dividing by the given denominator.  
  
##  \<a name="cdc__scalewindowext">\</a>  CDC::ScaleWindowExt  
 Modifies the window extents relative to the current values.  
  
<CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1149\</CodeContentPlaceHolder>  
 Specifies the amount by which to multiply the current x-extent.  
  
 <CodeContentPlaceHolder>1150\</CodeContentPlaceHolder>  
 Specifies the amount by which to divide the result of multiplying the current x-extent by the value of the <CodeContentPlaceHolder>1151\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>1152\</CodeContentPlaceHolder>  
 Specifies the amount by which to multiply the current y-extent.  
  
 <CodeContentPlaceHolder>1153\</CodeContentPlaceHolder>  
 Specifies the amount by which to divide the result of multiplying the current y-extent by the value of the <CodeContentPlaceHolder>1154\</CodeContentPlaceHolder> parameter.  
  
### Return Value  
 The previous window extents (in logical units) as a <CodeContentPlaceHolder>1155\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The formulas are written as follows:  
  
 <CodeContentPlaceHolder>1156\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>1157\</CodeContentPlaceHolder>  
  
 The new window extents are calculated by multiplying the current extents by the given numerator and then dividing by the given denominator.  
  
##  \<a name="cdc__scrolldc">\</a>  CDC::ScrollDC  
 Scrolls a rectangle of bits horizontally and vertically.  
  
<CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1158\</CodeContentPlaceHolder>  
 Specifies the number of horizontal scroll units.  
  
 *dy*  
 Specifies the number of vertical scroll units.  
  
 <CodeContentPlaceHolder>1159\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>1160\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>1161\</CodeContentPlaceHolder> object that contains the coordinates of the scrolling rectangle.  
  
 <CodeContentPlaceHolder>1162\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>1163\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>1164\</CodeContentPlaceHolder> object that contains the coordinates of the clipping rectangle. When this rectangle is smaller than the original one pointed to by <CodeContentPlaceHolder>1165\</CodeContentPlaceHolder>, scrolling occurs only in the smaller rectangle.  
  
 <CodeContentPlaceHolder>1166\</CodeContentPlaceHolder>  
 Identifies the region uncovered by the scrolling process. The <CodeContentPlaceHolder>1167\</CodeContentPlaceHolder> function defines this region; it is not necessarily a rectangle.  
  
 <CodeContentPlaceHolder>1168\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>1169\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>1170\</CodeContentPlaceHolder> object that receives the coordinates of the rectangle that bounds the scrolling update region. This is the largest rectangular area that requires repainting. The values in the structure or object when the function returns are in client coordinates, regardless of the mapping mode for the given device context.  
  
### Return Value  
 Nonzero if scrolling is executed; otherwise 0.  
  
### Remarks  
 If <CodeContentPlaceHolder>1171\</CodeContentPlaceHolder> is **NULL**, Windows does not compute the update rectangle. If both <CodeContentPlaceHolder>1172\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1173\</CodeContentPlaceHolder> are **NULL**, Windows does not compute the update region. If <CodeContentPlaceHolder>1174\</CodeContentPlaceHolder> is not **NULL**, Windows assumes that it contains a valid pointer to the region uncovered by the scrolling process (defined by the <CodeContentPlaceHolder>1175\</CodeContentPlaceHolder> member function). The update region returned in <CodeContentPlaceHolder>1176\</CodeContentPlaceHolder> can be passed to <CodeContentPlaceHolder>1177\</CodeContentPlaceHolder> if required.  
  
 An application should use the <CodeContentPlaceHolder>1178\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>1179\</CodeContentPlaceHolder> when it is necessary to scroll the entire client area of a window. Otherwise, it should use <CodeContentPlaceHolder>1180\</CodeContentPlaceHolder>.  
  
##  \<a name="cdc__selectclippath">\</a>  CDC::SelectClipPath  
 Selects the current path as a clipping region for the device context, combining the new region with any existing clipping region by using the specified mode.  
  
<CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1181\</CodeContentPlaceHolder>  
 Specifies the way to use the path. The following values are allowed:  
  
-   **RGN_AND** The new clipping region includes the intersection (overlapping areas) of the current clipping region and the current path.  
  
-   **RGN_COPY** The new clipping region is the current path.  
  
-   **RGN_DIFF** The new clipping region includes the areas of the current clipping region, and those of the current path are excluded.  
  
-   **RGN_OR** The new clipping region includes the union (combined areas) of the current clipping region and the current path.  
  
-   **RGN_XOR** The new clipping region includes the union of the current clipping region and the current path, but without the overlapping areas.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The device context identified must contain a closed path.  
  
##  \<a name="cdc__selectcliprgn">\</a>  CDC::SelectClipRgn  
 Selects the given region as the current clipping region for the device context.  
  
<CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1182\</CodeContentPlaceHolder>  
 Identifies the region to be selected.  
  
-   For the first version of this function, if this value is **NULL**, the entire client area is selected and output is still clipped to the window.  
  
-   For the second version of this function, this handle can be **NULL** only when the **RGN_COPY** mode is specified.  
  
 <CodeContentPlaceHolder>1183\</CodeContentPlaceHolder>  
 Specifies the operation to be performed. It must be one of the following values:  
  
-   **RGN_AND** The new clipping region combines the overlapping areas of the current clipping region and the region identified by <CodeContentPlaceHolder>1184\</CodeContentPlaceHolder>.  
  
-   **RGN_COPY** The new clipping region is a copy of the region identified by <CodeContentPlaceHolder>1185\</CodeContentPlaceHolder>. This is functionality is identical to the first version of <CodeContentPlaceHolder>1186\</CodeContentPlaceHolder>. If the region identified by <CodeContentPlaceHolder>1187\</CodeContentPlaceHolder> is **NULL**, the new clipping region becomes the default clipping region (a null region).  
  
-   **RGN_DIFF** The new clipping region combines the areas of the current clipping region with those areas excluded from the region identified by <CodeContentPlaceHolder>1188\</CodeContentPlaceHolder>.  
  
-   **RGN_OR** The new clipping region combines the current clipping region and the region identified by <CodeContentPlaceHolder>1189\</CodeContentPlaceHolder>.  
  
-   **RGN_XOR** The new clipping region combines the current clipping region and the region identified by <CodeContentPlaceHolder>1190\</CodeContentPlaceHolder> but excludes any overlapping areas.  
  
### Return Value  
 The region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** New clipping region has overlapping borders.  
  
-   **ERROR** Device context or region is not valid.  
  
-   **NULLREGION** New clipping region is empty.  
  
-   **SIMPLEREGION** New clipping region has no overlapping borders.  
  
### Remarks  
 Only a copy of the selected region is used. The region itself can be selected for any number of other device contexts, or it can be deleted.  
  
 The function assumes that the coordinates for the given region are specified in device units. Some printer devices support text output at a higher resolution than graphics output in order to retain the precision needed to express text metrics. These devices report device units at the higher resolution, that is, in text units. These devices then scale coordinates for graphics so that several reported device units map to only 1 graphic unit. You should always call the <CodeContentPlaceHolder>1191\</CodeContentPlaceHolder> function using text units.  
  
 Applications that must take the scaling of graphics objects in the GDI can use the **GETSCALINGFACTOR** printer escape to determine the scaling factor. This scaling factor affects clipping. If a region is used to clip graphics, GDI divides the coordinates by the scaling factor. If the region is used to clip text, GDI makes no scaling adjustment. A scaling factor of 1 causes the coordinates to be divided by 2; a scaling factor of 2 causes the coordinates to be divided by 4; and so on.  
  
##  \<a name="cdc__selectobject">\</a>  CDC::SelectObject  
 Selects an object into the device context.  
  
<CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
### Parameters  
 *pPen*  
 A pointer to a [CPen](../vs140/cpen-class.md) object to be selected.  
  
 <CodeContentPlaceHolder>1192\</CodeContentPlaceHolder>  
 A pointer to a [CBrush](../vs140/cbrush-class.md) object to be selected.  
  
 <CodeContentPlaceHolder>1193\</CodeContentPlaceHolder>  
 A pointer to a [CFont](../vs140/cfont-class.md) object to be selected.  
  
 <CodeContentPlaceHolder>1194\</CodeContentPlaceHolder>  
 A pointer to a [CBitmap](../vs140/cbitmap-class.md) object to be selected.  
  
 <CodeContentPlaceHolder>1195\</CodeContentPlaceHolder>  
 A pointer to a [CRgn](../vs140/crgn-class.md) object to be selected.  
  
 <CodeContentPlaceHolder>1196\</CodeContentPlaceHolder>  
 A pointer to a [CGdiObject](../vs140/cgdiobject-class.md) object to be selected.  
  
### Return Value  
 A pointer to the object being replaced. This is a pointer to an object of one of the classes derived from <CodeContentPlaceHolder>1197\</CodeContentPlaceHolder>, such as <CodeContentPlaceHolder>1198\</CodeContentPlaceHolder>, depending on which version of the function is used. The return value is **NULL** if there is an error. This function may return a pointer to a temporary object. This temporary object is only valid during the processing of one Windows message. For more information, see <CodeContentPlaceHolder>1199\</CodeContentPlaceHolder>.  
  
 The version of the member function that takes a region parameter performs the same task as the <CodeContentPlaceHolder>1200\</CodeContentPlaceHolder> member function. Its return value can be any of the following:  
  
-   **COMPLEXREGION** New clipping region has overlapping borders.  
  
-   **ERROR** Device context or region is not valid.  
  
-   **NULLREGION** New clipping region is empty.  
  
-   **SIMPLEREGION** New clipping region has no overlapping borders.  
  
### Remarks  
 Class <CodeContentPlaceHolder>1201\</CodeContentPlaceHolder> provides five versions specialized for particular kinds of GDI objects, including pens, brushes, fonts, bitmaps, and regions. The newly selected object replaces the previous object of the same type. For example, if <CodeContentPlaceHolder>1202\</CodeContentPlaceHolder> of the general version of <CodeContentPlaceHolder>1203\</CodeContentPlaceHolder> points to a [CPen](../vs140/cpen-class.md) object, the function replaces the current pen with the pen specified by <CodeContentPlaceHolder>1204\</CodeContentPlaceHolder>.  
  
 An application can select a bitmap into memory device contexts only and into only one memory device context at a time. The format of the bitmap must either be monochrome or compatible with the device context; if it is not, <CodeContentPlaceHolder>1205\</CodeContentPlaceHolder> returns an error.  
  
 For Windows 3.1 and later, the <CodeContentPlaceHolder>1206\</CodeContentPlaceHolder> function returns the same value whether it is used in a metafile or not. Under previous versions of Windows, <CodeContentPlaceHolder>1207\</CodeContentPlaceHolder> returned a nonzero value for success and 0 for failure when it was used in a metafile.  
  
##  \<a name="cdc__selectpalette">\</a>  CDC::SelectPalette  
 Selects the logical palette that is specified by <CodeContentPlaceHolder>1208\</CodeContentPlaceHolder> as the selected palette object of the device context.  
  
<CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1209\</CodeContentPlaceHolder>  
 Identifies the logical palette to be selected. This palette must already have been created with the <CodeContentPlaceHolder>1210\</CodeContentPlaceHolder> member function [CreatePalette](../vs140/cpalette-class.md#cpalette__createpalette).  
  
 <CodeContentPlaceHolder>1211\</CodeContentPlaceHolder>  
 Specifies whether the logical palette is forced to be a background palette. If <CodeContentPlaceHolder>1212\</CodeContentPlaceHolder> is nonzero, the selected palette is always a background palette, regardless of whether the window has the input focus. If <CodeContentPlaceHolder>1213\</CodeContentPlaceHolder> is 0 and the device context is attached to a window, the logical palette is a foreground palette when the window has the input focus.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>1214\</CodeContentPlaceHolder> object identifying the logical palette replaced by the palette specified by <CodeContentPlaceHolder>1215\</CodeContentPlaceHolder>. It is **NULL** if there is an error.  
  
### Remarks  
 The new palette becomes the palette object used by GDI to control colors displayed in the device context and replaces the previous palette.  
  
 An application can select a logical palette into more than one device context. However, changes to a logical palette will affect all device contexts for which it is selected. If an application selects a palette into more than one device context, the device contexts must all belong to the same physical device.  
  
##  \<a name="cdc__selectstockobject">\</a>  CDC::SelectStockObject  
 Selects a [CGdiObject](../vs140/cgdiobject-class.md) object that corresponds to one of the predefined stock pens, brushes, or fonts.  
  
<CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1216\</CodeContentPlaceHolder>  
 Specifies the kind of stock object desired. It can be one of the following values:  
  
-   **BLACK_BRUSH** Black brush.  
  
-   **DKGRAY_BRUSH** Dark gray brush.  
  
-   **GRAY_BRUSH** Gray brush.  
  
-   **HOLLOW_BRUSH** Hollow brush.  
  
-   **LTGRAY_BRUSH** Light gray brush.  
  
-   **NULL_BRUSH** Null brush.  
  
-   **WHITE_BRUSH** White brush.  
  
-   **BLACK_PEN** Black pen.  
  
-   **NULL_PEN** Null pen.  
  
-   **WHITE_PEN** White pen.  
  
-   **ANSI_FIXED_FONT** ANSI fixed system font.  
  
-   **ANSI_VAR_FONT** ANSI variable system font.  
  
-   **DEVICE_DEFAULT_FONT** Device-dependent font.  
  
-   **OEM_FIXED_FONT** OEM-dependent fixed font.  
  
-   **SYSTEM_FONT** The system font. By default, Windows uses the system font to draw menus, dialog-box controls, and other text. It is best, however, not to rely on SYSTEM_FONT to obtain the font used by dialogs and windows. Instead, use the <CodeContentPlaceHolder>1217\</CodeContentPlaceHolder> function with the SPI_GETNONCLIENTMETRICS parameter to retrieve the current font. <CodeContentPlaceHolder>1218\</CodeContentPlaceHolder> takes into account the current theme and provides font information for captions, menus, and message dialogs.  
  
-   **SYSTEM_FIXED_FONT** The fixed-width system font used in Windows prior to version 3.0. This object is available for compatibility with earlier versions of Windows.  
  
-   **DEFAULT_PALETTE** Default color palette. This palette consists of the 20 static colors in the system palette.  
  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>1219\</CodeContentPlaceHolder> object that was replaced if the function is successful. The actual object pointed to is a [CPen](../vs140/cpen-class.md), [CBrush](../vs140/cbrush-class.md), or [CFont](../vs140/cfont-class.md) object. If the call is unsuccessful, the return value is **NULL**.  
  
##  \<a name="cdc__setabortproc">\</a>  CDC::SetAbortProc  
 Installs the abort procedure for the print job.  
  
<CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1220\</CodeContentPlaceHolder>  
 A pointer to the abort function to install as the abort procedure. For more about the callback function, see [Callback Function for CDC::SetAbortProc](../vs140/callback-function-for-cdc--setabortproc.md).  
  
### Return Value  
 Specifies the outcome of the <CodeContentPlaceHolder>1221\</CodeContentPlaceHolder> function. Some of the following values are more probable than others, but all are possible.  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User ended the job through the Print Manager.  
  
### Remarks  
 If an application is to allow the print job to be canceled during spooling, it must set the abort function before the print job is started with the [StartDoc](#cdc__startdoc) member function. The Print Manager calls the abort function during spooling to allow the application to cancel the print job or to process out-of-disk-space conditions. If no abort function is set, the print job will fail if there is not enough disk space for spooling.  
  
 Note that the features of Microsoft Visual C++ simplify the creation of the callback function passed to <CodeContentPlaceHolder>1222\</CodeContentPlaceHolder>. The address passed to the <CodeContentPlaceHolder>1223\</CodeContentPlaceHolder> member function is a pointer to a function exported with **__declspec(dllexport)** and with the <CodeContentPlaceHolder>1224\</CodeContentPlaceHolder> calling convention.  
  
 You also do not have to export the function name in an **EXPORTS** statement in your application's module-definition file. You can instead use the **EXPORT** function modifier, as in  
  
 **BOOL CALLBACK EXPORT** AFunction( **HDC**, <CodeContentPlaceHolder>1225\</CodeContentPlaceHolder>**);**  
  
 to cause the compiler to emit the proper export record for export by name without aliasing. This works for most needs. For some special cases, such as exporting a function by ordinal or aliasing the export, you still need to use an **EXPORTS** statement in a module-definition file.  
  
 Callback registration interfaces are now type-safe (you must pass in a function pointer that points to the right kind of function for the specific callback).  
  
 Also note that all callback functions must trap Microsoft Foundation exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
##  \<a name="cdc__setarcdirection">\</a>  CDC::SetArcDirection  
 Sets the drawing direction to be used for arc and rectangle functions.  
  
<CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
### Parameters  
 *nArcDirection*  
 Specifies the new arc direction. This parameter can be either of the following values:  
  
-   **AD_COUNTERCLOCKWISE** Figures drawn counterclockwise.  
  
-   **AD_CLOCKWISE** Figures drawn clockwise.  
  
### Return Value  
 Specifies the old arc direction, if successful; otherwise 0.  
  
### Remarks  
 The default direction is counterclockwise. The <CodeContentPlaceHolder>1226\</CodeContentPlaceHolder> function specifies the direction in which the following functions draw:  
  
|Arc|Pie|  
|---------|---------|  
|<CodeContentPlaceHolder>1227\</CodeContentPlaceHolder>|**Rectangle**|  
|<CodeContentPlaceHolder>1228\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>1229\</CodeContentPlaceHolder>|  
|**Ellipse**||  
  
##  \<a name="cdc__setattribdc">\</a>  CDC::SetAttribDC  
 Call this function to set the attribute device context, <CodeContentPlaceHolder>1230\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1231\</CodeContentPlaceHolder>  
 A Windows device context.  
  
### Remarks  
 This member function does not attach the device context to the <CodeContentPlaceHolder>1232\</CodeContentPlaceHolder> object. Only the output device context is attached to a <CodeContentPlaceHolder>1233\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__setbkcolor">\</a>  CDC::SetBkColor  
 Sets the current background color to the specified color.  
  
<CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1234\</CodeContentPlaceHolder>  
 Specifies the new background color.  
  
### Return Value  
 The previous background color as an RGB color value. If an error occurs, the return value is 0x80000000.  
  
### Remarks  
 If the background mode is **OPAQUE**, the system uses the background color to fill the gaps in styled lines, the gaps between hatched lines in brushes, and the background in character cells. The system also uses the background color when converting bitmaps between color and monochrome device contexts.  
  
 If the device cannot display the specified color, the system sets the background color to the nearest physical color.  
  
##  \<a name="cdc__setbkmode">\</a>  CDC::SetBkMode  
 Sets the background mode.  
  
<CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
### Parameters  
 *nBkMode*  
 Specifies the mode to be set. This parameter can be either of the following values:  
  
-   **OPAQUE** Background is filled with the current background color before the text, hatched brush, or pen is drawn. This is the default background mode.  
  
-   **TRANSPARENT** Background is not changed before drawing.  
  
### Return Value  
 The previous background mode.  
  
### Remarks  
 The background mode defines whether the system removes existing background colors on the drawing surface before drawing text, hatched brushes, or any pen style that is not a solid line.  
  
### Example  
  See the example for [CWnd::OnCtlColor](../vs140/cwnd-class.md#cwnd__onctlcolor).  
  
##  \<a name="cdc__setboundsrect">\</a>  CDC::SetBoundsRect  
 Controls the accumulation of bounding-rectangle information for the specified device context.  
  
<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1235\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>1236\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>1237\</CodeContentPlaceHolder> object that is used to set the bounding rectangle. Rectangle dimensions are given in logical coordinates. This parameter can be **NULL**.  
  
 <CodeContentPlaceHolder>1238\</CodeContentPlaceHolder>  
 Specifies how the new rectangle will be combined with the accumulated rectangle. This parameter can be a combination of the following values:  
  
-   **DCB_ACCUMULATE** Add the rectangle specified by <CodeContentPlaceHolder>1239\</CodeContentPlaceHolder> to the bounding rectangle (using a rectangle-union operation).  
  
-   **DCB_DISABLE** Turn off bounds accumulation.  
  
-   **DCB_ENABLE** Turn on bounds accumulation. (The default setting for bounds accumulation is disabled.)  
  
### Return Value  
 The current state of the bounding rectangle, if the function is successful. Like <CodeContentPlaceHolder>1240\</CodeContentPlaceHolder>, the return value can be a combination of **DCB_** values:  
  
-   **DCB_ACCUMULATE** The bounding rectangle is not empty. This value will always be set.  
  
-   **DCB_DISABLE** Bounds accumulation is off.  
  
-   **DCB_ENABLE** Bounds accumulation is on.  
  
### Remarks  
 Windows can maintain a bounding rectangle for all drawing operations. This rectangle can be queried and reset by the application. The drawing bounds are useful for invalidating bitmap caches.  
  
##  \<a name="cdc__setbrushorg">\</a>  CDC::SetBrushOrg  
 Specifies the origin that GDI will assign to the next brush that the application selects into the device context.  
  
<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the x-coordinate (in device units) of the new origin. This value must be in the range 0–7.  
  
 *y*  
 Specifies the y-coordinate (in device units) of the new origin. This value must be in the range 0–7.  
  
 <CodeContentPlaceHolder>1241\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the new origin. Each value must be in the range 0–7. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1242\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 The previous origin of the brush in device units.  
  
### Remarks  
 The default coordinates for the brush origin are (0, 0). To alter the origin of a brush, call the <CodeContentPlaceHolder>1243\</CodeContentPlaceHolder> function for the <CodeContentPlaceHolder>1244\</CodeContentPlaceHolder> object, call <CodeContentPlaceHolder>1245\</CodeContentPlaceHolder>, and then call the <CodeContentPlaceHolder>1246\</CodeContentPlaceHolder> member function to select the brush into the device context.  
  
 Do not use <CodeContentPlaceHolder>1247\</CodeContentPlaceHolder> with stock <CodeContentPlaceHolder>1248\</CodeContentPlaceHolder> objects.  
  
##  \<a name="cdc__setcoloradjustment">\</a>  CDC::SetColorAdjustment  
 Sets the color adjustment values for the device context using the specified values.  
  
<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1249\</CodeContentPlaceHolder>  
 Points to a [COLORADJUSTMENT](../vs140/coloradjustment-structure.md) data structure containing the color adjustment values.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The color adjustment values are used to adjust the input color of the source bitmap for calls to the <CodeContentPlaceHolder>1250\</CodeContentPlaceHolder> member function when **HALFTONE** mode is set.  
  
##  \<a name="cdc__setdcbrushcolor">\</a>  CDC::SetDCBrushColor  
 Sets the current device context (DC) brush color to the specified color value.  
  
<CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1251\</CodeContentPlaceHolder>  
 Specifies the new brush color.  
  
### Return Value  
 If the function succeeds, the return value specifies the previous DC brush color as a <CodeContentPlaceHolder>1252\</CodeContentPlaceHolder> value.  
  
 If the function fails, the return value is <CodeContentPlaceHolder>1253\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method emulates the functionality of the function                         [SetDCBrushColor](http://msdn.microsoft.com/library/windows/desktop/dd162969), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__setdcpencolor">\</a>  CDC::SetDCPenColor  
 Sets the current device context (DC) pen color to the specified color value.  
  
<CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1254\</CodeContentPlaceHolder>  
 Specifies the new pen color.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This member function utilizes the Win32 function                         [SetDCPenColor](http://msdn.microsoft.com/library/windows/desktop/dd162970), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__setgraphicsmode">\</a>  CDC::SetGraphicsMode  
 Sets the graphics mode for the specified device context.  
  
<CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1255\</CodeContentPlaceHolder>  
 Specifies the graphics mode. For a list of the values that this parameter can take, see                                 [SetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd162977).  
  
### Return Value  
 Returns the old graphics mode on success.  
  
 Returns 0 on failure. To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This method wraps the Windows GDI function                         [SetGraphicsMode](http://msdn.microsoft.com/library/windows/desktop/dd162977).  
  
##  \<a name="cdc__setlayout">\</a>  CDC::SetLayout  
 Call this member function to change the layout of the text and graphics for a device context to right to left, the standard layout for cultures such as Arabic and Hebrew.  
  
<CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1256\</CodeContentPlaceHolder>  
 Device context layout and bitmap control flags. It can be a combination of the following values.  
  
|Value|Meaning|  
|-----------|-------------|  
|LAYOUT_BITMAPORIENTATIONPRESERVED|Disables any reflection for calls to [CDC::BitBlt](#cdc__bitblt) and [CDC::StretchBlt](#cdc__stretchblt).|  
|LAYOUT_RTL|Sets the default horizontal layout to be right to left.|  
|LAYOUT_LTR|Sets the default layout to be left to right.|  
  
### Return Value  
 If successful, the previous layout of the device context.  
  
 If unsuccessful, **GDI_ERROR**. To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 Normally, you would not call **SetLayout** for a window. Rather, you control the right-to-left layout in a window by setting the [extended window styles](../vs140/extended-window-styles.md) such as **WS_EX_RTLREADING**. A device context, such as a printer or a metafile, does not inherit this layout. The only way to set the device context for a right-to-left layout is by calling **SetLayout**.  
  
 If you call **SetLayout(LAYOUT_RTL** ), **SetLayout** automatically changes the mapping mode to <CodeContentPlaceHolder>1257\</CodeContentPlaceHolder>. As a result, a subsequent call to [GetMapMode](#cdc__getmapmode) will return **MM_ISOTROPIC** instead of <CodeContentPlaceHolder>1258\</CodeContentPlaceHolder>.  
  
 In some cases, such as with many bitmaps, you may want to preserve the left-to-right layout. In these cases, render the image by calling <CodeContentPlaceHolder>1259\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1260\</CodeContentPlaceHolder>, then set the bitmap control flag for <CodeContentPlaceHolder>1261\</CodeContentPlaceHolder> to **LAYOUT_BITMAPORIENTATIONPRESERVED**.  
  
 Once you change the layout with the **LAYOUT_RTL** flag, the flags normally specifying right or left are reversed. To avoid confusion, you may want to define alternate names for the standard flags. For a list of suggested alternate flag names, see                         [SetLayout](http://msdn.microsoft.com/library/windows/desktop/dd162979) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__setmapmode">\</a>  CDC::SetMapMode  
 Sets the mapping mode.  
  
<CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1262\</CodeContentPlaceHolder>  
 Specifies the new mapping mode. It can be any one of the following values:  
  
-   <CodeContentPlaceHolder>1263\</CodeContentPlaceHolder> Logical units are converted to arbitrary units with arbitrarily scaled axes. Setting the mapping mode to <CodeContentPlaceHolder>1264\</CodeContentPlaceHolder> does not change the current window or viewport settings. To change the units, orientation, and scaling, call the [SetWindowExt](#cdc__setwindowext) and [SetViewportExt](#cdc__setviewportext) member functions.  
  
-   <CodeContentPlaceHolder>1265\</CodeContentPlaceHolder> Each logical unit is converted to 0.001 inch. Positive x is to the right; positive y is up.  
  
-   <CodeContentPlaceHolder>1266\</CodeContentPlaceHolder> Each logical unit is converted to 0.01 millimeter. Positive x is to the right; positive y is up.  
  
-   <CodeContentPlaceHolder>1267\</CodeContentPlaceHolder> Logical units are converted to arbitrary units with equally scaled axes; that is, 1 unit along the x-axis is equal to 1 unit along the y-axis. Use the <CodeContentPlaceHolder>1268\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1269\</CodeContentPlaceHolder> member functions to specify the desired units and the orientation of the axes. GDI makes adjustments as necessary to ensure that the x and y units remain the same size.  
  
-   <CodeContentPlaceHolder>1270\</CodeContentPlaceHolder> Each logical unit is converted to 0.01 inch. Positive x is to the right; positive y is up.  
  
-   <CodeContentPlaceHolder>1271\</CodeContentPlaceHolder> Each logical unit is converted to 0.1 millimeter. Positive x is to the right; positive y is up.  
  
-   <CodeContentPlaceHolder>1272\</CodeContentPlaceHolder> Each logical unit is converted to 1 device pixel. Positive x is to the right; positive y is down.  
  
-   <CodeContentPlaceHolder>1273\</CodeContentPlaceHolder> Each logical unit is converted to 1/20 of a point. (Because a point is 1/72 inch, a twip is 1/1440 inch.) Positive x is to the right; positive y is up.  
  
### Return Value  
 The previous mapping mode.  
  
### Remarks  
 The mapping mode defines the unit of measure used to convert logical units to device units; it also defines the orientation of the device's x- and y-axes. GDI uses the mapping mode to convert logical coordinates into the appropriate device coordinates. The <CodeContentPlaceHolder>1274\</CodeContentPlaceHolder> mode allows applications to work in device pixels, where 1 unit is equal to 1 pixel. The physical size of a pixel varies from device to device.  
  
 The <CodeContentPlaceHolder>1275\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1276\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1277\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1278\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>1279\</CodeContentPlaceHolder> modes are useful for applications that must draw in physically meaningful units (such as inches or millimeters). The <CodeContentPlaceHolder>1280\</CodeContentPlaceHolder> mode ensures a 1:1 aspect ratio, which is useful when it is important to preserve the exact shape of an image. The <CodeContentPlaceHolder>1281\</CodeContentPlaceHolder> mode allows the x- and y-coordinates to be adjusted independently.  
  
> [!NOTE]
>  If you call [SetLayout](#cdc__setlayout) to change the DC (device context) to right-to-left layout, **SetLayout** automatically changes the mapping mode to <CodeContentPlaceHolder>1282\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CView::OnPrepareDC](../vs140/cview-class.md#cview__onpreparedc).  
  
##  \<a name="cdc__setmapperflags">\</a>  CDC::SetMapperFlags  
 Changes the method used by the font mapper when it converts a logical font to a physical font.  
  
<CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1283\</CodeContentPlaceHolder>  
 Specifies whether the font mapper attempts to match a font's aspect height and width to the device. When this value is **ASPECT_FILTERING**, the mapper selects only fonts whose x-aspect and y-aspect exactly match those of the specified device.  
  
### Return Value  
 The previous value of the font-mapper flag.  
  
### Remarks  
 An application can use <CodeContentPlaceHolder>1284\</CodeContentPlaceHolder> to cause the font mapper to attempt to choose only a physical font that exactly matches the aspect ratio of the specified device.  
  
 An application that uses only raster fonts can use the <CodeContentPlaceHolder>1285\</CodeContentPlaceHolder> function to ensure that the font selected by the font mapper is attractive and readable on the specified device. Applications that use scalable (TrueType) fonts typically do not use <CodeContentPlaceHolder>1286\</CodeContentPlaceHolder>.  
  
 If no physical font has an aspect ratio that matches the specification in the logical font, GDI chooses a new aspect ratio and selects a font that matches this new aspect ratio.  
  
##  \<a name="cdc__setmiterlimit">\</a>  CDC::SetMiterLimit  
 Sets the limit for the length of miter joins for the device context.  
  
<CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
### Parameters  
 *fMiterLimit*  
 Specifies the new miter limit for the device context.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The miter length is defined as the distance from the intersection of the line walls on the inside of the join to the intersection of the line walls on the outside of the join. The miter limit is the maximum allowed ratio of the miter length to the line width. The default miter limit is 10.0.  
  
##  \<a name="cdc__setoutputdc">\</a>  CDC::SetOutputDC  
 Call this member function to set the output device context, <CodeContentPlaceHolder>1287\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1288\</CodeContentPlaceHolder>  
 A Windows device context.  
  
### Remarks  
 This member function can only be called when a device context has not been attached to the <CodeContentPlaceHolder>1289\</CodeContentPlaceHolder> object. This member function sets <CodeContentPlaceHolder>1290\</CodeContentPlaceHolder> but does not attach the device context to the <CodeContentPlaceHolder>1291\</CodeContentPlaceHolder> object.  
  
##  \<a name="cdc__setpixel">\</a>  CDC::SetPixel  
 Sets the pixel at the point specified to the closest approximation of the color specified by <CodeContentPlaceHolder>1292\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point to be set.  
  
 *y*  
 Specifies the logical y-coordinate of the point to be set.  
  
 <CodeContentPlaceHolder>1293\</CodeContentPlaceHolder>  
 A **COLORREF** RGB value that specifies the color used to paint the point. See                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of this value.  
  
 <CodeContentPlaceHolder>1294\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the point to be set. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1295\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 An RGB value for the color that the point is actually painted. This value can be different from that specified by <CodeContentPlaceHolder>1296\</CodeContentPlaceHolder> if an approximation of that color is used. If the function fails (if the point is outside the clipping region), the return value is –1.  
  
### Remarks  
 The point must be in the clipping region. If the point is not in the clipping region, the function does nothing.  
  
 Not all devices support the <CodeContentPlaceHolder>1297\</CodeContentPlaceHolder> function. To determine whether a device supports <CodeContentPlaceHolder>1298\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>1299\</CodeContentPlaceHolder> member function with the **RASTERCAPS** index and check the return value for the **RC_BITBLT** flag.  
  
##  \<a name="cdc__setpixelv">\</a>  CDC::SetPixelV  
 Sets the pixel at the specified coordinates to the closest approximation of the specified color.  
  
<CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the x-coordinate, in logical units, of the point to be set.  
  
 *y*  
 Specifies the y-coordinate, in logical units, of the point to be set.  
  
 <CodeContentPlaceHolder>1300\</CodeContentPlaceHolder>  
 Specifies the color to be used to paint the point.  
  
 <CodeContentPlaceHolder>1301\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the point to be set. You can pass either a [POINT](../vs140/point-structure.md) data structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The point must be in both the clipping region and the visible part of the device surface. Not all devices support the member function. For more information, see the **RC_BITBLT** capability in the <CodeContentPlaceHolder>1302\</CodeContentPlaceHolder> member function. <CodeContentPlaceHolder>1303\</CodeContentPlaceHolder> is faster than <CodeContentPlaceHolder>1304\</CodeContentPlaceHolder> because it does not need to return the color value of the point actually painted.  
  
##  \<a name="cdc__setpolyfillmode">\</a>  CDC::SetPolyFillMode  
 Sets the polygon-filling mode.  
  
<CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1305\</CodeContentPlaceHolder>  
 Specifies the new filling mode. This value may be either **ALTERNATE** or **WINDING**. The default mode set in Windows is **ALTERNATE**.  
  
### Return Value  
 The previous filling mode, if successful; otherwise 0.  
  
### Remarks  
 When the polygon-filling mode is **ALTERNATE**, the system fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, the system fills the area between the first and second side, between the third and fourth side, and so on. This mode is the default.  
  
 When the polygon-filling mode is **WINDING**, the system uses the direction in which a figure was drawn to determine whether to fill an area. Each line segment in a polygon is drawn in either a clockwise or a counterclockwise direction. Whenever an imaginary line drawn from an enclosed area to the outside of a figure passes through a clockwise line segment, a count is incremented. When the line passes through a counterclockwise line segment, the count is decremented. The area is filled if the count is nonzero when the line reaches the outside of the figure.  
  
##  \<a name="cdc__setrop2">\</a>  CDC::SetROP2  
 Sets the current drawing mode.  
  
<CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1306\</CodeContentPlaceHolder>  
 Specifies the new drawing mode. It can be any of the following values:  
  
-   **R2_BLACK** Pixel is always black.  
  
-   **R2_WHITE** Pixel is always white.  
  
-   **R2_NOP** Pixel remains unchanged.  
  
-   **R2_NOT** Pixel is the inverse of the screen color.  
  
-   **R2_COPYPEN** Pixel is the pen color.  
  
-   **R2_NOTCOPYPEN** Pixel is the inverse of the pen color.  
  
-   **R2_MERGEPENNOT** Pixel is a combination of the pen color and the inverse of the screen color (final pixel = (NOT screen pixel) OR pen).  
  
-   **R2_MASKPENNOT** Pixel is a combination of the colors common to both the pen and the inverse of the screen (final pixel = (NOT screen pixel) AND pen).  
  
-   **R2_MERGENOTPEN** Pixel is a combination of the screen color and the inverse of the pen color (final pixel = (NOT pen) OR screen pixel).  
  
-   **R2_MASKNOTPEN** Pixel is a combination of the colors common to both the screen and the inverse of the pen (final pixel = (NOT pen) AND screen pixel).  
  
-   **R2_MERGEPEN** Pixel is a combination of the pen color and the screen color (final pixel = pen OR screen pixel).  
  
-   **R2_NOTMERGEPEN** Pixel is the inverse of the **R2_MERGEPEN** color (final pixel = NOT(pen OR screen pixel)).  
  
-   **R2_MASKPEN** Pixel is a combination of the colors common to both the pen and the screen (final pixel = pen AND screen pixel).  
  
-   **R2_NOTMASKPEN** Pixel is the inverse of the **R2_MASKPEN** color (final pixel = NOT(pen AND screen pixel)).  
  
-   **R2_XORPEN** Pixel is a combination of the colors that are in the pen or in the screen, but not in both (final pixel = pen XOR screen pixel).  
  
-   **R2_NOTXORPEN** Pixel is the inverse of the **R2_XORPEN** color (final pixel = NOT(pen XOR screen pixel)).  
  
### Return Value  
 The previous drawing mode.  
  
 It can be any of the values given in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 The drawing mode specifies how the colors of the pen and the interior of filled objects are combined with the color already on the display surface.  
  
 The drawing mode is for raster devices only; it does not apply to vector devices. Drawing modes are binary raster-operation codes representing all possible Boolean combinations of two variables, using the binary operators AND, OR, and XOR (exclusive OR), and the unary operation NOT.  
  
##  \<a name="cdc__setstretchbltmode">\</a>  CDC::SetStretchBltMode  
 Sets the bitmap-stretching mode for the <CodeContentPlaceHolder>1307\</CodeContentPlaceHolder> member function.  
  
<CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
### Parameters  
 *nStretchMode*  
 Specifies the stretching mode. It can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|**BLACKONWHITE**|Performs a Boolean AND operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves black pixels at the expense of white pixels.|  
|**COLORONCOLOR**|Deletes the pixels. This mode deletes all eliminated lines of pixels without trying to preserve their information.|  
|**HALFTONE**|Maps pixels from the source rectangle into blocks of pixels in the destination rectangle. The average color over the destination block of pixels approximates the color of the source pixels.|  
||After setting the **HALFTONE** stretching mode, an application must call the Win32 function                                                 [SetBrushOrgEx](http://msdn.microsoft.com/library/windows/desktop/dd162967) to set the brush origin. If it fails to do so, brush misalignment occurs.|  
|**STRETCH_ANDSCANS**|**Windows 95/98**: Same as **BLACKONWHITE**|  
|**STRETCH_DELETESCANS**|**Windows 95/98**: Same as **COLORONCOLOR**|  
|**STRETCH_HALFTONE**|**Windows 95/98**: Same as **HALFTONE**.|  
|**STRETCH_ORSCANS**|**Windows 95/98**: Same as **WHITEONBLACK**|  
|**WHITEONBLACK**|Performs a Boolean OR operation using the color values for the eliminated and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves white pixels at the expense of black pixels.|  
  
### Return Value  
 The previous stretching mode. It can be **STRETCH_ANDSCANS**, **STRETCH_DELETESCANS**, or **STRETCH_ORSCANS**.  
  
### Remarks  
 The bitmap-stretching mode defines how information is removed from bitmaps that are compressed by using the function.  
  
 The **BLACKONWHITE** ( **STRETCH_ANDSCANS**) and **WHITEONBLACK** ( **STRETCH_ORSCANS**) modes are typically used to preserve foreground pixels in monochrome bitmaps. The **COLORONCOLOR** ( **STRETCH_DELETESCANS**) mode is typically used to preserve color in color bitmaps.  
  
 The  **HALFTONE** mode requires more processing of the source image than the other three modes; it is slower than the others, but produces higher quality images. Also note that **SetBrushOrgEx** must be called after setting the **HALFTONE** mode to avoid brush misalignment.  
  
 Additional stretching modes might also be available depending on the capabilities of the device driver.  
  
##  \<a name="cdc__settextalign">\</a>  CDC::SetTextAlign  
 Sets the text-alignment flags.  
  
<CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1308\</CodeContentPlaceHolder>  
 Specifies text-alignment flags. The flags specify the relationship between a point and a rectangle that bounds the text. The point can be either the current position or coordinates specified by a text-output function. The rectangle that bounds the text is defined by the adjacent character cells in the text string. The <CodeContentPlaceHolder>1309\</CodeContentPlaceHolder> parameter can be one or more flags from the following three categories. Choose only one flag from each category. The first category affects text alignment in the x-direction:  
  
-   **TA_CENTER** Aligns the point with the horizontal center of the bounding rectangle.  
  
-   **TA_LEFT** Aligns the point with the left side of the bounding rectangle. This is the default setting.  
  
-   **TA_RIGHT** Aligns the point with the right side of the bounding rectangle.  
  
 The second category affects text alignment in the y-direction:  
  
-   **TA_BASELINE** Aligns the point with the base line of the chosen font.  
  
-   **TA_BOTTOM** Aligns the point with the bottom of the bounding rectangle.  
  
-   **TA_TOP** Aligns the point with the top of the bounding rectangle. This is the default setting.  
  
 The third category determines whether the current position is updated when text is written:  
  
-   **TA_NOUPDATECP** Does not update the current position after each call to a text-output function. This is the default setting.  
  
-   **TA_UPDATECP** Updates the current x-position after each call to a text-output function. The new position is at the right side of the bounding rectangle for the text. When this flag is set, the coordinates specified in calls to the <CodeContentPlaceHolder>1310\</CodeContentPlaceHolder> member function are ignored.  
  
### Return Value  
 The previous text-alignment setting, if successful. The low-order byte contains the horizontal setting and the high-order byte contains the vertical setting; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>1311\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1312\</CodeContentPlaceHolder> member functions use these flags when positioning a string of text on a display or device. The flags specify the relationship between a specific point and a rectangle that bounds the text. The coordinates of this point are passed as parameters to the <CodeContentPlaceHolder>1313\</CodeContentPlaceHolder> member function. The rectangle that bounds the text is formed by the adjacent character cells in the text string.  
  
##  \<a name="cdc__settextcharacterextra">\</a>  CDC::SetTextCharacterExtra  
 Sets the amount of intercharacter spacing.  
  
<CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1314\</CodeContentPlaceHolder>  
 Specifies the amount of extra space (in logical units) to be added to each character. If the current mapping mode is not <CodeContentPlaceHolder>1315\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1316\</CodeContentPlaceHolder> is transformed and rounded to the nearest pixel.  
  
### Return Value  
 The amount of the previous intercharacter spacing.  
  
### Remarks  
 GDI adds this spacing to each character, including break characters, when it writes a line of text to the device context. The default value for the amount of intercharacter spacing is 0.  
  
##  \<a name="cdc__settextcolor">\</a>  CDC::SetTextColor  
 Sets the text color to the specified color.  
  
<CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1317\</CodeContentPlaceHolder>  
 Specifies the color of the text as an RGB color value.  
  
### Return Value  
 An RGB value for the previous text color.  
  
### Remarks  
 The system will use this text color when writing text to this device context and also when converting bitmaps between color and monochrome device contexts.  
  
 If the device cannot represent the specified color, the system sets the text color to the nearest physical color. The background color for a character is specified by the <CodeContentPlaceHolder>1318\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1319\</CodeContentPlaceHolder> member functions.  
  
### Example  
  See the example for [CWnd::OnCtlColor](../vs140/cwnd-class.md#cwnd__onctlcolor).  
  
##  \<a name="cdc__settextjustification">\</a>  CDC::SetTextJustification  
 Adds space to the break characters in a string.  
  
<CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1320\</CodeContentPlaceHolder>  
 Specifies the total extra space to be added to the line of text (in logical units). If the current mapping mode is not <CodeContentPlaceHolder>1321\</CodeContentPlaceHolder>, the value given by this parameter is converted to the current mapping mode and rounded to the nearest device unit.  
  
 *nBreakCount*  
 Specifies the number of break characters in the line.  
  
### Return Value  
 One if the function is successful; otherwise 0.  
  
### Remarks  
 An application can use the <CodeContentPlaceHolder>1322\</CodeContentPlaceHolder> member functions to retrieve a font's break character.  
  
 After the <CodeContentPlaceHolder>1323\</CodeContentPlaceHolder> member function is called, a call to a text-output function (such as <CodeContentPlaceHolder>1324\</CodeContentPlaceHolder>) distributes the specified extra space evenly among the specified number of break characters. The break character is usually the space character (ASCII 32), but may be defined by a font as some other character.  
  
 The member function <CodeContentPlaceHolder>1325\</CodeContentPlaceHolder> is typically used with <CodeContentPlaceHolder>1326\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>1327\</CodeContentPlaceHolder> computes the width of a given line before alignment. An application can determine how much space to specify in the <CodeContentPlaceHolder>1328\</CodeContentPlaceHolder> parameter by subtracting the value returned by <CodeContentPlaceHolder>1329\</CodeContentPlaceHolder> from the width of the string after alignment.  
  
 The <CodeContentPlaceHolder>1330\</CodeContentPlaceHolder> function can be used to align a line that contains multiple runs in different fonts. In this case, the line must be created piecemeal by aligning and writing each run separately.  
  
 Because rounding errors can occur during alignment, the system keeps a running error term that defines the current error. When aligning a line that contains multiple runs, <CodeContentPlaceHolder>1331\</CodeContentPlaceHolder> automatically uses this error term when it computes the extent of the next run. This allows the text-output function to blend the error into the new run.  
  
 After each line has been aligned, this error term must be cleared to prevent it from being incorporated into the next line. The term can be cleared by calling <CodeContentPlaceHolder>1332\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>1333\</CodeContentPlaceHolder> set to 0.  
  
##  \<a name="cdc__setviewportext">\</a>  CDC::SetViewportExt  
 Sets the x- and y-extents of the viewport of the device context.  
  
<CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1334\</CodeContentPlaceHolder>  
 Specifies the x-extent of the viewport (in device units).  
  
 <CodeContentPlaceHolder>1335\</CodeContentPlaceHolder>  
 Specifies the y-extent of the viewport (in device units).  
  
 <CodeContentPlaceHolder>1336\</CodeContentPlaceHolder>  
 Specifies the x- and y-extents of the viewport (in device units).  
  
### Return Value  
 The previous extents of the viewport as a [CSize](../vs140/csize-class.md) object. When an error occurs, the x- and y-coordinates of the returned <CodeContentPlaceHolder>1337\</CodeContentPlaceHolder> object are both set to 0.  
  
### Remarks  
 The viewport, along with the device-context window, defines how GDI maps points in the logical coordinate system to points in the coordinate system of the actual device. In other words, they define how GDI converts logical coordinates into device coordinates.  
  
 When the following mapping modes are set, calls to <CodeContentPlaceHolder>1338\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1339\</CodeContentPlaceHolder> are ignored:  
  
|MM_HIENGLISH|MM_LOMETRIC|  
|-------------------|------------------|  
|<CodeContentPlaceHolder>1340\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>1341\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>1342\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>1343\</CodeContentPlaceHolder>|  
  
 When <CodeContentPlaceHolder>1344\</CodeContentPlaceHolder> mode is set, an application must call the <CodeContentPlaceHolder>1345\</CodeContentPlaceHolder> member function before it calls <CodeContentPlaceHolder>1346\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CView::OnPrepareDC](../vs140/cview-class.md#cview__onpreparedc).  
  
##  \<a name="cdc__setviewportorg">\</a>  CDC::SetViewportOrg  
 Sets the viewport origin of the device context.  
  
<CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the x-coordinate (in device units) of the origin of the viewport. The value must be within the range of the device coordinate system.  
  
 *y*  
 Specifies the y-coordinate (in device units) of the origin of the viewport. The value must be within the range of the device coordinate system.  
  
 <CodeContentPlaceHolder>1347\</CodeContentPlaceHolder>  
 Specifies the origin of the viewport. The values must be within the range of the device coordinate system. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1348\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 The previous origin of the viewport (in device coordinates) as a <CodeContentPlaceHolder>1349\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The viewport, along with the device-context window, defines how GDI maps points in the logical coordinate system to points in the coordinate system of the actual device. In other words, they define how GDI converts logical coordinates into device coordinates.  
  
 The viewport origin marks the point in the device coordinate system to which GDI maps the window origin, a point in the logical coordinate system specified by the **SetWindowOrg** member function. GDI maps all other points by following the same process required to map the window origin to the viewport origin. For example, all points in a circle around the point at the window origin will be in a circle around the point at the viewport origin. Similarly, all points in a line that passes through the window origin will be in a line that passes through the viewport origin.  
  
### Example  
  See the example for [CView::OnPrepareDC](../vs140/cview-class.md#cview__onpreparedc).  
  
##  \<a name="cdc__setwindowext">\</a>  CDC::SetWindowExt  
 Sets the x- and y-extents of the window associated with the device context.  
  
<CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1350\</CodeContentPlaceHolder>  
 Specifies the x-extent (in logical units) of the window.  
  
 <CodeContentPlaceHolder>1351\</CodeContentPlaceHolder>  
 Specifies the y-extent (in logical units) of the window.  
  
 <CodeContentPlaceHolder>1352\</CodeContentPlaceHolder>  
 Specifies the x- and y-extents (in logical units) of the window.  
  
### Return Value  
 The previous extents of the window (in logical units) as a <CodeContentPlaceHolder>1353\</CodeContentPlaceHolder> object. If an error occurs, the x- and y-coordinates of the returned <CodeContentPlaceHolder>1354\</CodeContentPlaceHolder> object are both set to 0.  
  
### Remarks  
 The window, along with the device-context viewport, defines how GDI maps points in the logical coordinate system to points in the device coordinate system.  
  
 When the following mapping modes are set, calls to <CodeContentPlaceHolder>1355\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1356\</CodeContentPlaceHolder> functions are ignored:  
  
-   <CodeContentPlaceHolder>1357\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>1358\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>1359\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>1360\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>1361\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>1362\</CodeContentPlaceHolder>  
  
 When <CodeContentPlaceHolder>1363\</CodeContentPlaceHolder> mode is set, an application must call the <CodeContentPlaceHolder>1364\</CodeContentPlaceHolder> member function before calling <CodeContentPlaceHolder>1365\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CView::OnPrepareDC](../vs140/cview-class.md#cview__onpreparedc).  
  
##  \<a name="cdc__setwindoworg">\</a>  CDC::SetWindowOrg  
 Sets the window origin of the device context.  
  
<CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the new origin of the window.  
  
 *y*  
 Specifies the logical y-coordinate of the new origin of the window.  
  
 <CodeContentPlaceHolder>1366\</CodeContentPlaceHolder>  
 Specifies the logical coordinates of the new origin of the window. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>1367\</CodeContentPlaceHolder> object for this parameter.  
  
### Return Value  
 The previous origin of the window as a <CodeContentPlaceHolder>1368\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The window, along with the device-context viewport, defines how GDI maps points in the logical coordinate system to points in the device coordinate system.  
  
 The window origin marks the point in the logical coordinate system from which GDI maps the viewport origin, a point in the device coordinate system specified by the **SetWindowOrg** function. GDI maps all other points by following the same process required to map the window origin to the viewport origin. For example, all points in a circle around the point at the window origin will be in a circle around the point at the viewport origin. Similarly, all points in a line that passes through the window origin will be in a line that passes through the viewport origin.  
  
##  \<a name="cdc__setworldtransform">\</a>  CDC::SetWorldTransform  
 Sets a two-dimensional linear transformation between world space and page space for the specified device context. This transformation can be used to scale, rotate, shear, or translate graphics output.  
  
<CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1369\</CodeContentPlaceHolder>  
 Reference to an                                 [XFORM](http://msdn.microsoft.com/library/windows/desktop/dd145228) structure that contains the transformation data.  
  
### Return Value  
 Returns a nonzero value on success.  
  
 Returns 0 on failure.  
  
 To get extended error information, call                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This method wraps the Windows GDI function                         [SetWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145104).  
  
##  \<a name="cdc__startdoc">\</a>  CDC::StartDoc  
 Informs the device driver that a new print job is starting and that all subsequent <CodeContentPlaceHolder>1370\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1371\</CodeContentPlaceHolder> calls should be spooled under the same job until an <CodeContentPlaceHolder>1372\</CodeContentPlaceHolder> call occurs.  
  
<CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
### Parameters  
 *lpDocInfo*  
 Points to a                                 [DOCINFO](http://msdn.microsoft.com/library/windows/desktop/dd183574) structure containing the name of the document file and the name of the output file.  
  
 *lpszDocName*  
 Pointer to a string containing the name of the document file.  
  
### Return Value  
 If the function succeeds, the return value is greater than zero. This value is the print job identifier for the document.  
  
 If the function fails, the return value is less than or equal to zero.  
  
### Remarks  
 This ensures that documents longer than one page will not be interspersed with other jobs.  
  
 For Windows versions 3.1 and later, this function replaces the **STARTDOC** printer escape. Using this function ensures that documents containing more than one page are not interspersed with other print jobs.  
  
 <CodeContentPlaceHolder>1373\</CodeContentPlaceHolder> should not be used inside metafiles.  
  
### Example  
 This code fragment gets the default printer, opens a print job, and spools one page with "Hello, World!" on it. Because the text printed by this code isn't scaled to the printer's logical units, the output text may be in such small letters that the result is unreadable. The CDC scaling functions, such as <CodeContentPlaceHolder>1374\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1375\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>1376\</CodeContentPlaceHolder>, can be used to fix the scaling.  
  
 [!code[NVC_MFCDocView#41](../vs140/codesnippet/CPP/cdc-class_13.cpp)]  
  
##  \<a name="cdc__startpage">\</a>  CDC::StartPage  
 Call this member function to prepare the printer driver to receive data.  
  
<CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
### Return Value  
 Greater than or equal to 0 if the function is successful, or a negative value if an error occurred.  
  
### Remarks  
 <CodeContentPlaceHolder>1377\</CodeContentPlaceHolder> supersedes the **NEWFRAME** and **BANDINFO** escapes.  
  
 For an overview of the sequence of printing calls, see the [StartDoc](#cdc__startdoc) member function.  
  
 The system disables the <CodeContentPlaceHolder>1378\</CodeContentPlaceHolder> member function between calls to <CodeContentPlaceHolder>1379\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1380\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CDC::StartDoc](#cdc__startdoc).  
  
##  \<a name="cdc__stretchblt">\</a>  CDC::StretchBlt  
 Copies a bitmap from a source rectangle into a destination rectangle, stretching or compressing the bitmap if necessary to fit the dimensions of the destination rectangle.  
  
<CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the x-coordinate (in logical units) of the upper-left corner of the destination rectangle.  
  
 *y*  
 Specifies the y-coordinate (in logical units) of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>1381\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the destination rectangle.  
  
 <CodeContentPlaceHolder>1382\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the destination rectangle.  
  
 <CodeContentPlaceHolder>1383\</CodeContentPlaceHolder>  
 Specifies the source device context.  
  
 <CodeContentPlaceHolder>1384\</CodeContentPlaceHolder>  
 Specifies the x-coordinate (in logical units) of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>1385\</CodeContentPlaceHolder>  
 Specifies the y-coordinate (in logical units) of the upper-left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>1386\</CodeContentPlaceHolder>  
 Specifies the width (in logical units) of the source rectangle.  
  
 <CodeContentPlaceHolder>1387\</CodeContentPlaceHolder>  
 Specifies the height (in logical units) of the source rectangle.  
  
 *dwRop*  
 Specifies the raster operation to be performed. Raster operation codes define how GDI combines colors in output operations that involve a current brush, a possible source bitmap, and a destination bitmap. This parameter may be one of the following values:  
  
-   **BLACKNESS** Turns all output black.  
  
-   **DSTINVERT** Inverts the destination bitmap.  
  
-   **MERGECOPY** Combines the pattern and the source bitmap using the Boolean AND operator.  
  
-   **MERGEPAINT** Combines the inverted source bitmap with the destination bitmap using the Boolean OR operator.  
  
-   **NOTSRCCOPY** Copies the inverted source bitmap to the destination.  
  
-   **NOTSRCERASE** Inverts the result of combining the destination and source bitmaps using the Boolean OR operator.  
  
-   **PATCOPY** Copies the pattern to the destination bitmap.  
  
-   **PATINVERT** Combines the destination bitmap with the pattern using the Boolean XOR operator.  
  
-   **PATPAINT** Combines the inverted source bitmap with the pattern using the Boolean OR operator. Combines the result of this operation with the destination bitmap using the Boolean OR operator.  
  
-   **SRCAND** Combines pixels of the destination and source bitmaps using the Boolean AND operator.  
  
-   **SRCCOPY** Copies the source bitmap to the destination bitmap.  
  
-   **SRCERASE** Inverts the destination bitmap and combines the result with the source bitmap using the Boolean AND operator.  
  
-   **SRCINVERT** Combines pixels of the destination and source bitmaps using the Boolean XOR operator.  
  
-   **SRCPAINT** Combines pixels of the destination and source bitmaps using the Boolean OR operator.  
  
-   **WHITENESS** Turns all output white.  
  
### Return Value  
 Nonzero if the bitmap is drawn; otherwise 0.  
  
### Remarks  
 The function uses the stretching mode of the destination device context (set by <CodeContentPlaceHolder>1388\</CodeContentPlaceHolder>) to determine how to stretch or compress the bitmap.  
  
 The <CodeContentPlaceHolder>1389\</CodeContentPlaceHolder> function moves the bitmap from the source device given by <CodeContentPlaceHolder>1390\</CodeContentPlaceHolder> to the destination device represented by the device-context object whose member function is being called. The <CodeContentPlaceHolder>1391\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1392\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1393\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>1394\</CodeContentPlaceHolder> parameters define the upper-left corner and dimensions of the source rectangle. The                         *x*,                         *y*, <CodeContentPlaceHolder>1395\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>1396\</CodeContentPlaceHolder> parameters give the upper-left corner and dimensions of the destination rectangle. The raster operation specified by                         *dwRop* defines how the source bitmap and the bits already on the destination device are combined.  
  
 The <CodeContentPlaceHolder>1397\</CodeContentPlaceHolder> function creates a mirror image of a bitmap if the signs of the <CodeContentPlaceHolder>1398\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1399\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1400\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1401\</CodeContentPlaceHolder> parameters differ. If <CodeContentPlaceHolder>1402\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1403\</CodeContentPlaceHolder> have different signs, the function creates a mirror image of the bitmap along the x-axis. If <CodeContentPlaceHolder>1404\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1405\</CodeContentPlaceHolder> have different signs, the function creates a mirror image of the bitmap along the y-axis.  
  
 The <CodeContentPlaceHolder>1406\</CodeContentPlaceHolder> function stretches or compresses the source bitmap in memory and then copies the result to the destination. If a pattern is to be merged with the result, it is not merged until the stretched source bitmap is copied to the destination. If a brush is used, it is the selected brush in the destination device context. The destination coordinates are transformed according to the destination device context; the source coordinates are transformed according to the source device context.  
  
 If the destination, source, and pattern bitmaps do not have the same color format, <CodeContentPlaceHolder>1407\</CodeContentPlaceHolder> converts the source and pattern bitmaps to match the destination bitmaps. The foreground and background colors of the destination device context are used in the conversion.  
  
 If <CodeContentPlaceHolder>1408\</CodeContentPlaceHolder> must convert a monochrome bitmap to color, it sets white bits (1) to the background color and black bits (0) to the foreground color. To convert color to monochrome, it sets pixels that match the background color to white (1) and sets all other pixels to black (0). The foreground and background colors of the device context with color are used.  
  
 Not all devices support the <CodeContentPlaceHolder>1409\</CodeContentPlaceHolder> function. To determine whether a device supports <CodeContentPlaceHolder>1410\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>1411\</CodeContentPlaceHolder> member function with the **RASTERCAPS** index and check the return value for the **RC_STRETCHBLT** flag.  
  
##  \<a name="cdc__strokeandfillpath">\</a>  CDC::StrokeAndFillPath  
 Closes any open figures in a path, strokes the outline of the path by using the current pen, and fills its interior by using the current brush.  
  
<CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The device context must contain a closed path. The <CodeContentPlaceHolder>1412\</CodeContentPlaceHolder> member function has the same effect as closing all the open figures in the path, and stroking and filling the path separately, except that the filled region will not overlap the stroked region even if the pen is wide.  
  
##  \<a name="cdc__strokepath">\</a>  CDC::StrokePath  
 Renders the specified path by using the current pen.  
  
<CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The device context must contain a closed path.  
  
##  \<a name="cdc__tabbedtextout">\</a>  CDC::TabbedTextOut  
 Call this member function to write a character string at the specified location, expanding tabs to the values specified in the array of tab-stop positions.  
  
<CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the starting point of the string.  
  
 *y*  
 Specifies the logical y-coordinate of the starting point of the string.  
  
 <CodeContentPlaceHolder>1413\</CodeContentPlaceHolder>  
 Points to the character string to draw. You can pass either a pointer to an array of characters or a [CString](../vs140/cstringt-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>1414\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string. If <CodeContentPlaceHolder>1415\</CodeContentPlaceHolder> is –1, the length is calculated.  
  
 <CodeContentPlaceHolder>1416\</CodeContentPlaceHolder>  
 Specifies the number of values in the array of tab-stop positions.  
  
 <CodeContentPlaceHolder>1417\</CodeContentPlaceHolder>  
 Points to an array containing the tab-stop positions (in logical units). The tab stops must be sorted in increasing order; the smallest x-value should be the first item in the array.  
  
 <CodeContentPlaceHolder>1418\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the starting position from which tabs are expanded (in logical units).  
  
 <CodeContentPlaceHolder>1419\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>1420\</CodeContentPlaceHolder> object that contains the specified characters.  
  
### Return Value  
 The dimensions of the string (in logical units) as a <CodeContentPlaceHolder>1421\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Text is written in the currently selected font. If <CodeContentPlaceHolder>1422\</CodeContentPlaceHolder> is 0 and <CodeContentPlaceHolder>1423\</CodeContentPlaceHolder> is **NULL**, tabs are expanded to eight times the average character width.  
  
 If <CodeContentPlaceHolder>1424\</CodeContentPlaceHolder> is 1, the tab stops are separated by the distance specified by the first value in the <CodeContentPlaceHolder>1425\</CodeContentPlaceHolder> array. If the <CodeContentPlaceHolder>1426\</CodeContentPlaceHolder> array contains more than one value, a tab stop is set for each value in the array, up to the number specified by <CodeContentPlaceHolder>1427\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>1428\</CodeContentPlaceHolder> parameter allows an application to call the <CodeContentPlaceHolder>1429\</CodeContentPlaceHolder> function several times for a single line. If the application calls the function more than once with the <CodeContentPlaceHolder>1430\</CodeContentPlaceHolder> set to the same value each time, the function expands all tabs relative to the position specified by <CodeContentPlaceHolder>1431\</CodeContentPlaceHolder>.  
  
 By default, the current position is not used or updated by the function. If an application needs to update the current position when it calls the function, the application can call the [SetTextAlign](#cdc__settextalign) member function with <CodeContentPlaceHolder>1432\</CodeContentPlaceHolder> set to **TA_UPDATECP**. When this flag is set, Windows ignores the                         *x* and                         *y* parameters on subsequent calls to <CodeContentPlaceHolder>1433\</CodeContentPlaceHolder>, using the current position instead.  
  
##  \<a name="cdc__textout">\</a>  CDC::TextOut  
 Writes a character string at the specified location using the currently selected font.  
  
<CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the starting point of the text.  
  
 *y*  
 Specifies the logical y-coordinate of the starting point of the text.  
  
 <CodeContentPlaceHolder>1434\</CodeContentPlaceHolder>  
 Points to the character string to be drawn.  
  
 <CodeContentPlaceHolder>1435\</CodeContentPlaceHolder>  
 Specifies the number of characters in the string.  
  
 <CodeContentPlaceHolder>1436\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>1437\</CodeContentPlaceHolder> object that contains the characters to be drawn.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 Character origins are at the upper-left corner of the character cell. By default, the current position is not used or updated by the function.  
  
 If an application needs to update the current position when it calls <CodeContentPlaceHolder>1438\</CodeContentPlaceHolder>, the application can call the <CodeContentPlaceHolder>1439\</CodeContentPlaceHolder> member function with <CodeContentPlaceHolder>1440\</CodeContentPlaceHolder> set to **TA_UPDATECP**. When this flag is set, Windows ignores the                         *x* and                         *y* parameters on subsequent calls to <CodeContentPlaceHolder>1441\</CodeContentPlaceHolder>, using the current position instead.  
  
### Example  
  See the example for [CDC::BeginPath](#cdc__beginpath).  
  
##  \<a name="cdc__transparentblt">\</a>  CDC::TransparentBlt  
 Call this member function to transfer a bit-block of the color data, which corresponds to a rectangle of pixels from the specified source device context, into a destination device context.  
  
<CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>1442\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>1443\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>1444\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>1445\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>1446\</CodeContentPlaceHolder>  
 Pointer to the source device context.  
  
 <CodeContentPlaceHolder>1447\</CodeContentPlaceHolder>  
 Specifies the x-coordinate, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1448\</CodeContentPlaceHolder>  
 Specifies the y-coordinate, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1449\</CodeContentPlaceHolder>  
 Specifies the width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1450\</CodeContentPlaceHolder>  
 Specifies the height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>1451\</CodeContentPlaceHolder>  
 The RGB color in the source bitmap to treat as transparent.  
  
### Return Value  
 **TRUE** if successful; otherwise **FALSE**.  
  
### Remarks  
 <CodeContentPlaceHolder>1452\</CodeContentPlaceHolder> allows for transparency; that is, the RGB color indicated by <CodeContentPlaceHolder>1453\</CodeContentPlaceHolder> is rendered transparent for the transfer.  
  
 For more information, see                         [TransparentBlt](http://msdn.microsoft.com/library/windows/desktop/dd145141) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cdc__updatecolors">\</a>  CDC::UpdateColors  
 Updates the client area of the device context by matching the current colors in the client area to the system palette on a pixel-by-pixel basis.  
  
<CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
### Remarks  
 An inactive window with a realized logical palette may call <CodeContentPlaceHolder>1454\</CodeContentPlaceHolder> as an alternative to redrawing its client area when the system palette changes.  
  
 For more information about using color palettes, see                         [UpdateColors](http://msdn.microsoft.com/library/windows/desktop/dd145166) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The <CodeContentPlaceHolder>1455\</CodeContentPlaceHolder> member function typically updates a client area faster than redrawing the area. However, because the function performs the color translation based on the color of each pixel before the system palette changed, each call to this function results in the loss of some color accuracy.  
  
##  \<a name="cdc__widenpath">\</a>  CDC::WidenPath  
 Redefines the current path as the area that would be painted if the path were stroked using the pen currently selected into the device context.  
  
<CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 This function is successful only if the current pen is a geometric pen created by the second version of <CodeContentPlaceHolder>1456\</CodeContentPlaceHolder> member function, or if the pen is created with the first version of <CodeContentPlaceHolder>1457\</CodeContentPlaceHolder> and has a width, in device units, of greater than 1. The device context must contain a closed path. Any Bzier curves in the path are converted to sequences of straight lines approximating the widened curves. As such, no Bzier curves remain in the path after <CodeContentPlaceHolder>1458\</CodeContentPlaceHolder> is called.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPaintDC](../vs140/cpaintdc-class.md)   
 [CWindowDC](../vs140/cwindowdc-class.md)   
 [CClientDC](../vs140/cclientdc-class.md)   
 [CMetaFileDC](../vs140/cmetafiledc-class.md)