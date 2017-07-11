import { XiongHuiTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: XiongHuiTemplatePage;

  beforeEach(() => {
    page = new XiongHuiTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
