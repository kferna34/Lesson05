﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_01
{
    /**
     * <summary>
     * This is the course class - we are using this as
     * a custom data type for our Teacher and Student classes
     * </summary>
     * 
     * @class Course
     */
    class Course
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++
        private string _code;
        private string _description;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public string Code
        {
            get
            {
                return this._code;
            }

            set
            {
                this._code = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }

            set
            {
                this._description = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: Code and Description
         * </summary>
         * 
         * @constructor Course
         * @param {string} code
         * @param {string} description
         */
        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}

