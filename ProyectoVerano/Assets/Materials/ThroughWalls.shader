Shader "Custom/ThroughWalls"
{
    Properties
    {
        _Color("Main Color", Color) = (1,1,1,1)
        _Color1("Walls Color", Color) = (1,1,1,1)
        _MainTex("Base (RGB) Gloss (A)", 2D) = "white" {}
    }

    Category
    {
        SubShader
        {
            Tags { "Queue" = "Overlay+1"  "RenderType" = "Transparent"}

            Pass
            {
                 Blend SrcAlpha OneMinusSrcAlpha
                 ZWrite Off
                 ZTest Greater
                 Lighting Off
                 Color[_Color1]
            }
            Pass
            {
                Blend SrcAlpha OneMinusSrcAlpha
                 ZTest Less
                 Color[_Color]
            }
        }
    }
    FallBack "Diffuse"
}
