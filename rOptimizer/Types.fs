module Types
    // Makes the monster type
    type Monster(id : int, name : string, level : int, base_hp : double, base_atk : double, base_def : double,
                 base_spd : double, base_critrate : int, base_critdmg : int, base_res : int, base_acc : int, 
                 set_hp : double, set_atk : double, set_def : double, set_spd : double, set_critrate : int, 
                 set_critdmg : int, set_res : int, set_acc : int, runeset_1 : string, runeset_2 : string, 
                 runeset_3 : string) = 
        member val ID = id with get, set
        member val Name = name with get, set
        member val Level = level with get, set
        member val Base_HP = base_hp with get, set
        member val Base_Atk = base_atk with get, set
        member val Base_Def = base_def with get, set
        member val Base_Spd = base_spd with get, set
        member val Base_CritRate = base_critrate with get, set
        member val Base_CritDmg = base_critdmg with get, set
        member val Base_Res = base_res with get, set
        member val Base_Acc = base_acc with get, set
        member val Set_HP = set_hp with get, set
        member val Set_Atk = set_atk with get, set
        member val Set_Def = set_def with get, set
        member val Set_Spd = set_spd with get, set
        member val Set_CritRate = set_critrate with get, set
        member val Set_CritDmg = set_critdmg with get, set
        member val Set_Res = set_res with get, set
        member val Set_Acc = set_acc with get, set
        member val RuneSet_1 = runeset_1 with get, set
        member val RuneSet_2 = runeset_2 with get, set
        member val RuneSet_3 = runeset_3 with get, set
        
