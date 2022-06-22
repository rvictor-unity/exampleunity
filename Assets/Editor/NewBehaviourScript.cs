using System.Collections;
using System.Collections.Generic;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Reset()
    {
        var jwtEncoder = new JWT.JwtEncoder(new NoneAlgorithm(), new JsonNetSerializer(), new JwtBase64UrlEncoder());
    }
}
