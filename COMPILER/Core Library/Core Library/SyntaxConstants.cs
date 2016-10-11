﻿namespace Core.Library
{
    /**
     * <remarks>An enumeration with token and production node
     * constants.</remarks>
     */
    public enum SyntaxConstants
    {
        Task = 1001,
        Lead = 1002,
        Start = 1003,
        End = 1004,
        Var = 1005,
        id = 1006,
        AS = 1007,
        Let = 1008,
        Object = 1009,
        of = 1010,
        by = 1011,
        IS = 1012,
        Clear = 1013,
        Read = 1014,
        Say = 1015,
        Skip = 1016,
        Stop = 1017,
        If = 1018,
        Or = 1019,
        Otherwise = 1020,
        Option = 1021,
        State = 1022,
        Default = 1023,
        Until = 1024,
        Loop = 1025,
        LoopIf = 1026,
        Do = 1027,
        For = 1028,
        Response = 1029,
        EndIf = 1030,
        Int = 1031,
        Double = 1032,
        Char = 1033,
        String = 1034,
        Null = 1035,
        Array = 1036,
        Boolean = 1037,
        intlit = 1038,
        doublelit = 1039,
        charlit = 1040,
        stringlit = 1041,
        boollit = 1042,
        COL = 1043,
        SEM = 1044,
        DIE = 1045,
        PER = 1046,
        OP = 1047,
        CP = 1048,
        OB = 1049,
        CB = 1050,
        ADD = 1051,
        MIN = 1052,
        MUL = 1053,
        DIV = 1054,
        MOD = 1055,
        INC = 1056,
        DEC = 1057,
        ISEQ = 1058,
        NOTEQ = 1059,
        GREAT = 1060,
        LESS = 1061,
        LOGAND = 1062,
        LOGOR = 1063,
        NOT = 1064,
        EQ = 1065,
        COMMA = 1066,
        AT = 1067,
        GEQ = 1068,
        LEQ = 1069,
        WHITESPACE = 1070,
        Prod_start_program = 2001,
        Prod_program = 2002,
        Prod_global = 2003,
        Prod_global_choice = 2004,
        Prod_dtype = 2005,
        Prod_object = 2006,
        Prod_objdec_choice = 2007,
        Prod_var = 2008,
        Prod_objvar = 2009,
        Prod_varname = 2010,
        Prod_varnames = 2011,
        Prod_task = 2012,
        Prod_return = 2013,
        Prod_tparam = 2014,
        Prod_tparams = 2015,
        Prod_array = 2016,
        Prod_size = 2017,
        Prod_sizes = 2018,
        Prod_varlet = 2019,
        Prod_vardec = 2020,
        Prod_var_int = 2021,
        Prod_init_int = 2022,
        Prod_var_double = 2023,
        Prod_init_double = 2024,
        Prod_var_char = 2025,
        Prod_init_char = 2026,
        Prod_var_string = 2027,
        Prod_init_string = 2028,
        Prod_var_boolean = 2029,
        Prod_init_boolean = 2030,
        Prod_ids1 = 2031,
        Prod_ids2 = 2032,
        Prod_ids3 = 2033,
        Prod_ids4 = 2034,
        Prod_ids5 = 2035,
        Prod_ids1_tail = 2036,
        Prod_ids2_tail = 2037,
        Prod_ids3_tail = 2038,
        Prod_ids4_tail = 2039,
        Prod_ids5_tail = 2040,
        Prod_value1 = 2041,
        Prod_value2 = 2042,
        Prod_value3 = 2043,
        Prod_value4 = 2044,
        Prod_value5 = 2045,
        Prod_numvalue = 2046,
        Prod_numelement = 2047,
        Prod_operations1 = 2048,
        Prod_op_int = 2049,
        Prod_op1 = 2050,
        Prod_doublevalue = 2051,
        Prod_operations2 = 2052,
        Prod_op_double = 2053,
        Prod_op2 = 2054,
        Prod_math_op = 2055,
        Prod_incdec = 2056,
        Prod_relop1 = 2057,
        Prod_logop1 = 2058,
        Prod_logop2 = 2059,
        Prod_body = 2060,
        Prod_statements = 2061,
        Prod_functions = 2062,
        Prod_id_choices = 2063,
        Prod_subelement_choice = 2064,
        Prod_varinit = 2065,
        Prod_varinit_int = 2066,
        Prod_varinit_double = 2067,
        Prod_varinit_char = 2068,
        Prod_varinit_string = 2069,
        Prod_varinit_boolean = 2070,
        Prod_int = 2071,
        Prod_intchoices = 2072,
        Prod_intchoice1 = 2073,
        Prod_intchoice2 = 2074,
        Prod_double = 2075,
        Prod_doublechoices = 2076,
        Prod_doublechoice1 = 2077,
        Prod_doublechoice2 = 2078,
        Prod_char = 2079,
        Prod_string = 2080,
        Prod_boolean = 2081,
        Prod_task_id = 2082,
        Prod_param = 2083,
        Prod_params = 2084,
        Prod_value = 2085,
        Prod_io_statement = 2086,
        Prod_input = 2087,
        Prod_output = 2088,
        Prod_input_statement = 2089,
        Prod_concat = 2090,
        Prod_concat_value = 2091,
        Prod_subelement = 2092,
        Prod_input_id = 2093,
        Prod_multi = 2094,
        Prod_index = 2095,
        Prod_if_otherwise = 2096,
        Prod_or = 2097,
        Prod_otherwise = 2098,
        Prod_cond_loop = 2099,
        Prod_control = 2100,
        Prod_conditions = 2101,
        Prod_conditionschoice = 2102,
        Prod_multiconds = 2103,
        Prod_idschoice = 2104,
        Prod_idschoice1 = 2105,
        Prod_idsbody = 2106,
        Prod_conds_tail = 2107,
        Prod_log_ops = 2108,
        Prod_rel_ops = 2109,
        Prod_relop_num = 2110,
        Prod_relop_text = 2111,
        Prod_numval = 2112,
        Prod_option = 2113,
        Prod_optiontails = 2114,
        Prod_optiontail1 = 2115,
        Prod_optiontail2 = 2116,
        Prod_optiontail3 = 2117,
        Prod_state1 = 2118,
        Prod_state2 = 2119,
        Prod_state3 = 2120,
        Prod_default = 2121,
        Prod_incdecvar = 2122,
        Prod_loopstate = 2123,
        Prod_initialize = 2124,
        Prod_cond = 2125,
        Prod_taskdef = 2126,
        Prod_returntype = 2127,
        Prod_taskbody = 2128,
        Prod_taskbodytail = 2129,
        Prod_return_int = 2130,
        Prod_return_double = 2131,
        Prod_return_char = 2132,
        Prod_return_string = 2133,
        Prod_return_boolean = 2134,
        Prod_returntail = 2135,
        Prod_input_tail = 2136
    }
}
