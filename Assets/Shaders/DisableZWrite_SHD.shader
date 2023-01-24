Shader "Custom/DisableZWrite_SHD"
{
    SubShader{
        Tags{"RenderType" = "Opaque"}
        
        Pass{Zwrite Off}
        }
}
