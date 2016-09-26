/* Takes a path to an audio source in FLAC format and
 * encodes it to base64 format and stores it at Google
 * Cloud Storage.
 * 
 * Display list of available buckets
 * Asks user which to use 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.CloudSpeechAPI.v1beta1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.IO;

namespace convertAudio
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
