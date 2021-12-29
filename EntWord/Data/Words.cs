namespace EntWord.Data
{
    public static class Words
    {
        private static readonly List<string> words = new() 
        {
            "another","beef","bug","chocolate","answer","before","build","choose","ant","begin","bun","chopsticks",
            "any","behind","burn","Christmas","anyone","believe","bus","church","anything","bell","business","circle",
            "apartment","belong","businessman","city","appear","below","busy","clap","apple","belt","but","class","April",
            "bench","butter","classmate","arm","beside","butterfly","classroom","around","between","buy","clean","arrive",
            "bike","by","clear","art","big","cage","clerk","as","bird","cake","climb","ask","birthday","call","clock","at",
            "bite","camera","close","clothes","desk","eleven","fifteen","cloudy","dictionary","eleventh","fifteenth","club",
            "die","else","fifth","coat","different","e-mail","fifty","coffee","difficult","end","fight","Coke","dig","engineer",
            "fill","cold","dining","room","English","finally","collect","dinner","enjoy","find","color","dirty","enough",
            "fine","come","dish","enter","finger","comb","do","envelope","finish","comfortable","doctor","eraser","fire",
            "comic","dodge","ball","even","first","common","dog","even","fish","computer","doll","evening","fisherman",
            "convenient","dollar","ever","five","cook","door","every","fix","cookie","dot","everyone","floor","cool","down",
            "everything","flower","copy","dozen","example","flute","corner","dragon","excellent","fly","correct","draw",
            "except","follow","cost","drawer","excited","food","couch","dream","exciting","foot","count","dress","excuse",
            "for","country","drink","exercise","foreign","course","drive","expensive","foreigner","cousin","driver","experience",
            "forget","cover","drop","eye","fork","cow","drum","face","forty","cowboy","dry","fact","four","crazy","duck","factory",
            "fourteen","cross","dumpling","fail","fourteenth","cry","during","fall","fourth","cup","each","family","fox","cut",
            "ear","famous","free","cute","early","fan","French","fries","dance","earth","far","fresh","dangerous","east","farm",
            "Friday","dark","Easter","farmer","friend","date","easy","fast","friendly","daughter","eat","fat","frisbee",
            "day","egg","father","frog","dead","eight","favorite","from","dear","eighteen","February","front","December","eighth",
            "feed","fruit","decide","eighty","feel","fry","delicious","either","festival","full","observe","obsession","obstacle",
            "obtain","obvious","obviously","occasion","occasional","occupation","occupy","occur","ocean","o'clock","October","odd",
            "odds","offend","offense","offensive","offer","office","officer","official","offspring","often","pane","panel","panic",
            "panorama","pants","papa","papaya","paper","parachute","parade","paradise","paradoxically","paragon","paragraph","paralyze",
            "paramount","pardon","parent","park","parking","parlor","parrot","part","partial","partially","participant","participate",
            "particular","quaint","quake","qualify","quality","quantity","quarrel","quarrelsome","quarter","queen","queer","quest",
            "question","questionnaire","queue","quick","quiet","reason","reasonable","reassure","rebel","rebel","rebellion","rebellious",
            "rebuild","recall","recapture","receipt","receive","receiver","recent","reception","recession","recipient","reckless","reckon",
            "recognition","recognize","recollect","reconcile","reconstruction","search","season","seat","Second","secondary","secret",
            "secretary","section","secular","secure","security","seduce","seek","seemingly","segregate","seize","seldom","select",
            "selection","self","selfish","sell","semester","seminar","tsunami","tub","tube","tuberculosis","Tuesday","tuition","tumble",
            "tumor","tune","tunnel","turkey","turmoil","turn","tumpike","turtle","tutor","twelve","twenty","Venus","verb","verbal",
            "verdict","verify","versatile","verse","vertical","very","vet","vex","viable","vibration","vicious","victim","victimize",
            "victory","video","view","vigor","vigorously","villa","village","villain","whether","which","whichever","while","whisper",
            "whistle","white","who","whoever","whole","wholesale","wholly","whom","whose","why","wicked","wide","widen","widower",
            "width","wife","wild","wilderness","zeal","zealously","zebra","zero","zip","zone","zoo","zoology"
        };

        public static List<string> Shuffle()
        {
            var random = new Random();
            var shuffle = new List<string>();
            foreach (var word in words)
            {
                shuffle.Insert(random.Next(shuffle.Count + 1), word);
            }
            return shuffle;
        }
    }
}
