import BaseURL from './BaseURL'
import Logger from './Logger'
import axios from 'axios'

export default class REST{

  static async get(config, baseURL='backend'){
    config.method = 'GET';
    return this.connect(config, baseURL)
  }

  static async post(config, baseURL='backend'){
    config.method = 'POST';
    return this.connect(config, baseURL)
  }

  static async put(config, baseURL='backend'){
    config.method = 'PUT';
    return this.connect(config, baseURL)
  }

  static async delete(config, baseURL='backend'){
    config.method = 'DELETE';
    return this.connect(config, baseURL)
  }

  static async connect(config, baseURL='backend'){
    config.baseURL = baseURL === 'backend' ? BaseURL.backend : BaseURL.identity;
    config.responseType = config.responseType ? config.responseType : 'json';
    let res;    
    let error = new Error();
    try {
      res = await axios(config);
      // TODO: check response code here
      // if(res.status === 404 || res.status === 500){
        
      // } else if (res.status === 403) {
      //   // jump to login
      //   error.action = () => <Redirect to='/login' />
      //   throw `Error occurred with http post`
      // }
    } catch (e) {
      Logger.log(e);
      error.action && error.action();
      return error;
    }
    return res;
  }

}
