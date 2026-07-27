Shader "Custom/SkyTint"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _SkyColor ("Sky Color", Color) = (1, 0.5, 0.8)
        _Intensity ("Intensity", Range(0, 1)) = 0.5
        _TimeScale ("Time Scale", Float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            fixed4 _SkyColor;
            float _Intensity;
            float _TimeScale;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);

                // Add time-based variation for dynamic tint effect
                float time = _Time.y * _TimeScale;
                fixed4 dynamicTint = sin(time) * 0.5 + 0.5; // Sine wave to create a pulsing effect
                col.rgb += (_SkyColor.rgb * _Intensity) * dynamicTint;

                return col;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
