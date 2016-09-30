---
title: "Mip-map Generation Variant"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3b4b3583-0b01-4f5d-aacb-3f96d19111d9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mip-map Generation Variant
Enables mip-maps on textures that are not render targets.  
  
## Interpretation  
 Mip-maps are primarily used to eliminate aliasing artifacts in textures under minification by pre-calculating smaller versions of the texture. Although these additional textures consume GPU memory—about 33 percent more than the original texture—they're also more efficient because more of their surface area fits in the GPU texture cache and its contents achieve higher utilization.  
  
 For 3-D scenes, we recommend mip-maps when memory is available to store the additional textures because they increase both rendering performance and image quality.  
  
 If this variant shows a significant performance gain, it indicates that you are using textures without enabling mip-maps and thereby not getting the most from the texture cache.  
  
## Remarks  
 Mip-map generation is forced on every call to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that creates a source texture. Specifically, mip-map generation is forced when the D3D11_TEXTUR2D_DESC object passed in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> describes an unchanging shader resource; that is:  
  
-   The BindFlags member has only the D3D11_BIND_SHADER_RESOURCE flag set.  
  
-   The Usage member is set to either D3D11_USAGE_DEFUALT or D3D11_USAGE_IMMUTABLE.  
  
-   The CPUAccessFlags member is set to 0 (no CPU access).  
  
-   The SampleDesc member has its Count member set to 1 (no Multi-Sample Anti-Aliasing (MSAA)).  
  
-   The MipLevels member is set to 1 (no existing mip-map).  
  
 When initial data is supplied by the application, the texture format must support automatic mip-map generation—as determined by D3D11_FORMAT_SUPPORT_MIP_AUTOGEN—unless the format is BC1, BC2, or BC3; otherwise, the texture is not modified and no mip-maps are generated when initial data is supplied.  
  
 If mip-maps have been automatically generated for a texture, calls to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are modified during playback to use the mip-chain during texture sampling.  
  
## Example  
 The **Mip-map Generation** variant can be reproduced by using code like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To create a texture that has a full mip-chain, set <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to 0. The number of mip levels in a full mip-chain is floor(log2(n) + 1), where n is the largest dimension of the texture.  
  
 Remember that when you provide initial data to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must provide a D3D11_SUBRESOURCE_DATA object for each mip level.  
  
> [!NOTE]
>  If you want to provide your own mip level contents instead of generating them automatically, you must create your textures by using an image editor that supports mip-mapped textures and then load the file and pass the mip levels to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## See Also  
 [Half/Quarter Texture Dimensions Variant](../vs140/half-quarter-texture-dimensions-variant.md)