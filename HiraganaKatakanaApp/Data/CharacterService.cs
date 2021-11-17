using System.Collections.Generic;

namespace HiraganaKatakanaApp.Data
{
	public class CharacterService
	{
        private static readonly List<Character> characters = new()
        {
            new Character
            {
                value = "a",
                hiragana = "あ",
                katakana = "ア"
            },
            new Character
            {
                value = "i",
                hiragana = "い",
                katakana = "イ"
            },
            new Character
            {
                value = "u",
                hiragana = "う",
                katakana = "ウ"
            },
            new Character
            {
                value = "e",
                hiragana = "え",
                katakana = "エ"
            },
            new Character
            {
                value = "o",
                hiragana = "お",
                katakana = "オ"
            },
            new Character
            {
                value = "ka",
                hiragana = "か",
                katakana = "カ"
            },
            new Character
            {
                value = "ki",
                hiragana = "き",
                katakana = "キ"
            },
            new Character
            {
                value = "ku",
                hiragana = "く",
                katakana = "ク"
            },
            new Character
            {
                value = "ke",
                hiragana = "け",
                katakana = "ケ"
            },
            new Character
            {
                value = "ko",
                hiragana = "こ",
                katakana = "コ"
            },
            new Character
            {
                value = "sa",
                hiragana = "さ",
                katakana = "サ"
            },
            new Character
            {
                value = "shi",
                hiragana = "し",
                katakana = "シ"
            },
            new Character
            {
                value = "su",
                hiragana = "す",
                katakana = "ス"
            },
            new Character
            {
                value = "se",
                hiragana = "せ",
                katakana = "セ"
            },
            new Character
            {
                value = "so",
                hiragana = "そ",
                katakana = "ソ"
            },
            new Character
            {
                value = "ta",
                hiragana = "た",
                katakana = "タ"
            },
            new Character
            {
                value = "chi",
                hiragana = "ち",
                katakana = "チ"
            },
            new Character
            {
                value = "tsu",
                hiragana = "つ",
                katakana = "ツ"
            },
            new Character
            {
                value = "te",
                hiragana = "て",
                katakana = "テ"
            },
            new Character
            {
                value = "to",
                hiragana = "と",
                katakana = "ト"
            },
            new Character
            {
                value = "na",
                hiragana = "な",
                katakana = "ナ"
            },
            new Character
            {
                value = "ni",
                hiragana = "に",
                katakana = "ニ"
            },
            new Character
            {
                value = "nu",
                hiragana = "ぬ",
                katakana = "ヌ"
            },
            new Character
            {
                value = "ne",
                hiragana = "ね",
                katakana = "ネ"
            },
            new Character
            {
                value = "no",
                hiragana = "の",
                katakana = "ノ"
            },
            new Character
            {
                value = "ha",
                hiragana = "は",
                katakana = "ハ"
            },
            new Character
            {
                value = "hi",
                hiragana = "ひ",
                katakana = "ヒ"
            },
            new Character
            {
                value = "fu",
                hiragana = "ふ",
                katakana = "フ"
            },
            new Character
            {
                value = "he",
                hiragana = "へ",
                katakana = "ヘ"
            },
            new Character
            {
                value = "ho",
                hiragana = "ほ",
                katakana = "ホ"
            },
            new Character
            {
                value = "ma",
                hiragana = "ま",
                katakana = "マ"
            },
            new Character
            {
                value = "mi",
                hiragana = "み",
                katakana = "ミ"
            },
            new Character
            {
                value = "mu",
                hiragana = "む",
                katakana = "ミ"
            },
            new Character
            {
                value = "me",
                hiragana = "め",
                katakana = "メ"
            },
            new Character
            {
                value = "mo",
                hiragana = "も",
                katakana = "モ"
            },
            new Character
            {
                value = "ya",
                hiragana = "や",
                katakana = "ヤ"
            },
            new Character
            {
                value = "yu",
                hiragana = "ゆ",
                katakana = "ユ"
            },
            new Character
            {
                value = "yo",
                hiragana = "よ",
                katakana = "ヨ"
            },
            new Character
            {
                value = "ra",
                hiragana = "ら",
                katakana = "ラ"
            },
            new Character
            {
                value = "ri",
                hiragana = "り",
                katakana = "リ"
            },
            new Character
            {
                value = "ru",
                hiragana = "る",
                katakana = "ル"
            },
            new Character
            {
                value = "re",
                hiragana = "れ",
                katakana = "レ"
            },
            new Character
            {
                value = "ro",
                hiragana = "ろ",
                katakana = "ロ"
            },
            new Character
            {
                value = "wa",
                hiragana = "わ",
                katakana = "ワ"
            },
            new Character
            {
                value = "wo",
                hiragana = "を",
                katakana = "ヲ"
            },
            new Character
            {
                value = "n",
                hiragana = "ん",
                katakana = "ン"
            },
            new Character
            {
                value = "ga",
                hiragana = "が",
                katakana = "ガ"
            },
            new Character
            {
                value = "gi",
                hiragana = "ぎ",
                katakana = "ギ"
            },
            new Character
            {
                value = "gu",
                hiragana = "ぐ",
                katakana = "グ"
            },
            new Character
            {
                value = "ge",
                hiragana = "げ",
                katakana = "ゲ"
            },
            new Character
            {
                value = "go",
                hiragana = "ご",
                katakana = "ゴ"
            },
            new Character
            {
                value = "za",
                hiragana = "ざ",
                katakana = "ザ"
            },
            new Character
            {
                value = "ji",
                hiragana = "じ",
                katakana = "ジ"
            },
            new Character
            {
                value = "zu",
                hiragana = "ず",
                katakana = "ズ"
            },
            new Character
            {
                value = "ze",
                hiragana = "ぜ",
                katakana = "ゼ"
            },
            new Character
            {
                value = "zo",
                hiragana = "ぞ",
                katakana = "ゾ"
            },
            new Character
            {
                value = "da",
                hiragana = "だ",
                katakana = "ダ"
            },
            new Character
            {
                value = "ji",
                hiragana = "ぢ",
                katakana = "ヂ"
            },
            new Character
            {
                value = "zu",
                hiragana = "づ",
                katakana = "ヅ"
            },
            new Character
            {
                value = "de",
                hiragana = "で",
                katakana = "デ"
            },
            new Character
            {
                value = "do",
                hiragana = "で",
                katakana = "ド"
            },
            new Character
            {
                value = "ba",
                hiragana = "ば",
                katakana = "ダ"
            },
            new Character
            {
                value = "bi",
                hiragana = "び",
                katakana = "バ"
            },
            new Character
            {
                value = "bu",
                hiragana = "ぶ",
                katakana = "ビ"
            },
            new Character
            {
                value = "be",
                hiragana = "べ",
                katakana = "ベ"
            },
            new Character
            {
                value = "bo",
                hiragana = "ぼ",
                katakana = "ボ"
            },
            new Character
            {
                value = "pa",
                hiragana = "ぱ",
                katakana = "パ"
            },
            new Character
            {
                value = "pi",
                hiragana = "ぴ",
                katakana = "ピ"
            },
            new Character
            {
                value = "pu",
                hiragana = "ぷ",
                katakana = "プ"
            },
            new Character
            {
                value = "pe",
                hiragana = "ぺ",
                katakana = "ペ"
            },
            new Character
            {
                value = "po",
                hiragana = "ぽ",
                katakana = "ポ"
            },
            new Character
            {
                value = "kya",
                hiragana = "きゃ",
                katakana = "キャ"
            },
            new Character
            {
                value = "kyu",
                hiragana = "きゅ",
                katakana = "キュ"
            },
            new Character
            {
                value = "kyo",
                hiragana = "きょ",
                katakana = "キョ"
            },
            new Character
            {
                value = "sha",
                hiragana = "しゃ",
                katakana = "シャ"
            },
            new Character
            {
                value = "shu",
                hiragana = "しゅ",
                katakana = "シュ"
            },
            new Character
            {
                value = "sho",
                hiragana = "しょ",
                katakana = "ショ"
            },
            new Character
            {
                value = "cha",
                hiragana = "ちゃ",
                katakana = "チャ"
            },
            new Character
            {
                value = "chu",
                hiragana = "ちゅ",
                katakana = "チュ"
            },
            new Character
            {
                value = "cho",
                hiragana = "ちょ",
                katakana = "チョ"
            },
            new Character
            {
                value = "nya",
                hiragana = "にゃ",
                katakana = "ニャ"
            },
            new Character
            {
                value = "nyu",
                hiragana = "にゅ",
                katakana = "ニュ"
            },
            new Character
            {
                value = "nyo",
                hiragana = "にょ",
                katakana = "ニョ"
            },
            new Character
            {
                value = "hya",
                hiragana = "ひゃ",
                katakana = "ヒャ"
            },
            new Character
            {
                value = "hyu",
                hiragana = "ひゅ",
                katakana = "ヒュ"
            },
            new Character
            {
                value = "hyo",
                hiragana = "ひょ",
                katakana = "ヒョ"
            },
            new Character
            {
                value = "mya",
                hiragana = "みゃ",
                katakana = "ミャ"
            },
            new Character
            {
                value = "myu",
                hiragana = "ひゅ",
                katakana = ""
            },
            new Character
            {
                value = "myo",
                hiragana = "みゅ",
                katakana = "ミュ"
            },
            new Character
            {
                value = "rya",
                hiragana = "りゃ",
                katakana = "ミョ"
            },
            new Character
            {
                value = "ryu",
                hiragana = "りゅ",
                katakana = "リャ"
            },
            new Character
            {
                value = "ryo",
                hiragana = "りょ",
                katakana = "リュ"
            },
            new Character
            {
                value = "gya",
                hiragana = "ぎゃ",
                katakana = "ギャ"
            },
            new Character
            {
                value = "gyu",
                hiragana = "ぎゅ",
                katakana = "ギュ"
            },
            new Character
            {
                value = "gyo",
                hiragana = "ぎょ",
                katakana = "ギョ"
            },
            new Character
            {
                value = "ja",
                hiragana = "じゃ",
                katakana = "ジャ"
            },
            new Character
            {
                value = "ju",
                hiragana = "じゅ",
                katakana = "ジュ"
            },
            new Character
            {
                value = "jo",
                hiragana = "じょ",
                katakana = "ジョ"
            },
            new Character
            {
                value = "bya",
                hiragana = "びゃ",
                katakana = "ジュ"
            },
            new Character
            {
                value = "byu",
                hiragana = "びゅ",
                katakana = "ビュ"
            },
            new Character
            {
                value = "byo",
                hiragana = "びょ",
                katakana = "ビョ"
            },
            new Character
            {
                value = "pya",
                hiragana = "ぴゃ",
                katakana = "ピャ"
            },
            new Character
            {
                value = "pyu",
                hiragana = "ぴゅ",
                katakana = "ピュ"
            },
            new Character
            {
                value = "pyo",
                hiragana = "ぴょ",
                katakana = "ピョ"
            }
        };

        public static List<Character> GetHiragana()
		{
            return characters;
		}
	}
}
